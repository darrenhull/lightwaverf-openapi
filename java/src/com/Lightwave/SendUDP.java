package com.Lightwave;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.util.*;

/*
 * A server object that runs in own thread.
 * Waits for text UDP commands and then adds them to a buffer (FIFO)
 * Periodically removes items from buffer and sends UDP commands to port 9760 on LWRF box
 * Delay between UDP transmission prevents flooding of port 9760 on LWRF box
 */
public class SendUDP extends Thread {
	
	private static int threadCount = 0;
	private FileLogger m_logger; // Logging server object, runs in own thread.
	private static final int LightwavePortIn = 9760; // Port into Lightwave Wifi hub.
	private static final String BroadcastAddress = "255.255.255.255";  // Broadcast UDP address.
	private static int MessageCount = 0;
	public static DatagramSocket transmitSocket; // Socket for UDP transmission to LWRF port 9760
	public static Queue<String> m_buffer; // Simple queue to queue up UDP transmission that could be from a polling thread, or direct commands through API

	/*
	 * Constructor defaults to logging every 30 seconds
	 */
	public SendUDP(FileLogger logger) {
		    super("" + ++threadCount); // Store the thread name
			m_logger = logger;
			m_buffer = new LinkedList<String>(); // Create simple queue (FIFO) for buffering UDP commands
		    initialiseSockets();
		    start();
		  }
	
	/*
	 * Run thread, pulling off any items from the UDP commands buffer, then send across network
	 * (non-Javadoc)
	 * @see java.lang.Thread#run()
	 */
	  public void run() {
		 
		  while (m_buffer.size()>=0)
		  {
		
		    	if (!m_buffer.isEmpty()){
		        	//System.out.println("Getting from buffer: " + m_buffer.peek());
			    	netsendUDP(m_buffer.remove().toString());	// Send item by UDP to LWRF box and remove from buffer.	
		    	} else 
		    		{
		    		try {
						Thread.sleep(1000);
					} catch (InterruptedException e) {
						e.printStackTrace();
					}
		    		
		    		}
		
		  } 
		
	  	}
	  
	  /*
	   *  Initialise transmit sockets for UDP
	   */
	  public static void initialiseSockets(){
	    	try{
	    		transmitSocket = new DatagramSocket();
	    	} catch (IOException e){
	    		e.printStackTrace();
	    	}
	    	
	    }
	    
	  /* 
	   * Add UDP commands to a buffer.  Reason for buffer: asynchronous UDP calls coming from the API and from period polling for energy monitoring.
	   * If I don't buffer, then commands would flood UDP socket on LWRF box.
	   */
		public void sendUDP(String Command){
			m_buffer.add(Command);
			//System.out.println("Adding to buffer: " + Command);
		}
		
		/*
		 * Send the UDP commands from the buffer, waiting a period of time before sending next, so as not to flood UDP socket on LWRF 9760 port
		 */
		public void netsendUDP(String Command){
			littlePause(2500);	// Wait a while so not to flood LighwaveRF box		   
			Command = MessageCount + Command;
			incrementMessageCount();

			//System.out.println("Sending UDP Message: " + Command); // Command line output to see UDP command
			
			try {
					byte[] sendData = new byte[1024];
				    sendData = Command.getBytes();
				    InetAddress IPAddress =  InetAddress.getByName(BroadcastAddress);
				    DatagramPacket sendPacket = new DatagramPacket(sendData, sendData.length, IPAddress, LightwavePortIn); //Send broadcast UDP to 9760 port
				    transmitSocket.send(sendPacket);
					m_logger.logData("SENT," + Command);
				    
			} 
			catch (IOException e) {
				e.printStackTrace(); // Display if something went wrong
			}

		}
		
	    /*
	     * Increment message counter, so different messages have different IDs
	     * Important for getting corresponding OK acknowledgements from port 9761 tagged with the same counter value
	     */
	    private static void incrementMessageCount(){
	    if (MessageCount <=998) MessageCount++;
	    	else MessageCount = 000;
	    }
		
		
		/*
		 *  Simple Pause where timedelay is in milliseconds
		 */
		private static void littlePause(int timedelay)
		{
			try 
			{
			Thread.sleep(timedelay); // do nothing for delay milliseconds 
			} 
			catch(InterruptedException e)
			{
			e.printStackTrace();
			}
		}
		
	

}

