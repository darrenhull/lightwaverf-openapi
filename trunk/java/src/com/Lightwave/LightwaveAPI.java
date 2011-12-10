//Java Version - Eddie Pratt - eddie_pratt AT hotmail.com
package com.Lightwave;

import java.io.*;
import java.net.*;
import java.util.Calendar;

public class LightwaveAPI {
	
	public static final int STOP = 0, stop = 0; //Flags for relay stop
	public static final int OPEN = 1, open = 1; //Flags for relay open
	public static final int CLOSE = 2, close = 2; // Flags for relay close
	public static final int ON = 1, on = 1, LOCK = 1, lock = 1; //Flags on
	public static final int OFF = 0, off = 0, UNLOCK = 0, unlock = 0; //Flags off
	public static final int LightwavePortIn = 9760; // Port into Lightwave Wifi hub
	public static final int LightwavePortOut = 9761; // Port out from Lightwave Wifi hub
	public static final String BroadcastAddress = "255.255.255.255";  // Broadcast UDP address
	public static final int MaxRooms = 8; // Max number of rooms
	private static int MessageCount = 100;
	public static DatagramSocket transmitSocket; // For UDP transmission
	public static DatagramSocket receiveSocket; // For UDP receiving

	// Main Entry - Example Commands calling API 
	public static void main(String[] args) {	
		
		initialiseSockets(); // Open UDP sockets for comms.
		
		/* Example polling and logging of data from the wireless energy monitor connected to the LightwaveRF box.
		 * This will be spun out into a separate process/thread so that other commands can be executed whilst
		 * logging energy data in the background. 
		 */
		
		LogToCSV.openFile("LightwaveRF_Log_Energy.csv");		
		for (int tempcount = 1; tempcount<(10); tempcount++){
			LogToCSV.logData(pollEnergyMonitor());    // Poll wireless energy monitor attached to LighwaveRF Wifi hub - returns String for logging
			littlePause (1000);			     		 // Wait about 1 second between polling the monitor - adjust this to say, every 5 minutes (5 * 60 * 1000 milliseconds)	
		}
		LogToCSV.closeFile();

		
		/*
		sendRoomOff (1); // Turn everything off assigned in Room 1
		littlePause (3500); // Wait to see the result!
		
		sendRoomMood (1,3); // Activate predefined Mood 3 in Room 1
		littlePause (3500); // Wait to see the result!
		
		sendDeviceDim (1, 3, 88); // Dim Device 3 in Room 1 to 88% dim level
		littlePause (3500); // Wait to see the result!
		
		sendDeviceOnOff (1,3,OFF); // Turn off Device 3 in Room 1 
		littlePause (3500); // Wait to see the result!
		
		sendOpenCloseStop(1,6,OPEN); //For for inline relays. Open connects common and circuit 1 connection.
		littlePause (3500); // Wait to see the result!
		
		sendOpenCloseStop(1,6,CLOSE); //For inline relays. Close connects common and circuit 2 connection.
		littlePause (3500); // Wait to see the result!
		
		sendOpenCloseStop(1,6,STOP); //For inline relays. Stop disconnects both common and circuit 1 and circuit 2.
		littlePause (3500); // Wait to see the result!
		
		sendHeatOnOff(1,ON); // Turn On radiator TRV (radiator valve) in Room 1
		littlePause (3500); // Wait to see the result!

		sendAllRoomsOff(); // Turn everything off assigned in All Rooms (1 through to MaxRooms)
		*/
	}
	
	/* Force registration with the LWRF wifi box - use only once, before the other commands, to
	 * force your computer to try to register with the LWRF box. After calling, look at LWRF box display 
	 * and it will ask you to approve the device connecting. You'll need to click a button on the box.
	 * Once done you just use other commands as documented. 
	 */
	
	public static void forceRegistration(){
        String text = "693,!R1Fa"; //693 hasn't any relevance - just arbitrary instead of 000
        sendUDP(text);
	}
	
	// Poll wireless energy monitor attached to LightwaveRF Wifi box.
	/*
	 * Send a UDP message to port 9760, similar to the following, where 123 is just a message ID counter.
	 * 			123,@?\0
	 * 
	 * Listen on UDP port 9761, looking for a response to the message 123. The message response is the following format:
	 *			123,?W=150,7710,31480,4970
	 *
	 *   123 is the message ID corresponding the the message I sent. 
	 *   150 is the current kWh usage, 7710 is the max kWh usage in last 24 hours
	 *   31480 is the cumulative kWh usage since 12 midnight
	 *   4970 is kWH usage the previous day
	 */
	public static String pollEnergyMonitor(){
		String text = MessageCount + ",@?\0";  
        String response;
        
		sendUDP(text); //Poll for the energy reasings.
        littlePause(1000);
        response = receiveUDP();
		
		// Add a timestamp to response message.
	    Calendar c = Calendar.getInstance();
	    System.out.print("Received UDP Message," + c.getTime() + "," + response);
	    incrementMessageCount();
	    return (c.getTime() + "," + response);
	}
	
	// Switches off all devices in Room
	public static void sendRoomOff(int Room){
        String text = MessageCount + ",!R" + Room + "Fa\0";
        sendUDP(text);
	}

	// Switches off all devices in all Rooms
	public static void sendAllRoomsOff(){
		for (int i = 1; i<=MaxRooms; ++i){
			sendRoomOff(i);
			}
		}
	
	// Sends Mood change request for Room 
    public static void sendRoomMood(int Room, int Mood)
    {
        String text = MessageCount + ",!R"+ Room + "FmP" + Mood + "|";
        sendUDP(text);
    }
	
    // Send change request for Percent dim level to Device in Room
    public static void sendDeviceDim(int Room, int Device, int Percent)
    { 
        String pstr;
        pstr = "" + (int)(Math.floor(0.01* Percent * 32));
        String text = MessageCount + ",!R" + Room + "D" + Device + "FdP" + pstr + "|";
        sendUDP(text);
    }
    
    // Send on/off State to Device in Room
    public static void sendDeviceOnOff(int Room, int Device, int State)
    {
        String statestr;
        if(State==ON) statestr = "1"; 
        		else statestr = "0";
        String text = MessageCount + ",!R" + Room + "D" + Device + "F" + statestr + "|";
        sendUDP(text);
    }
   
	// Send Lock/Unlock to a switching Device in Room
	public static void sendDeviceLockUnlock(int Room, int Device, int State){
        String statestr;
        if(State==lock) statestr = "l"; //lock 
        		else statestr = "u"; //unlock
        String text = MessageCount + ",!R" + Room + "D" + Device + "F" + statestr + "|";
        sendUDP(text);	
		}
		
	// Send Open/Close/Stop to a relay Device in Room
	public static void sendOpenCloseStop(int Room, int Device, int State){
        String statestr;
   
        switch (State) {
	        case STOP    :      statestr =  "^"; break; // Breaks circuit between common and both inputs.
	        case OPEN   :       statestr =  ">"; break; // Connects circuit between common and input 1.
	        case CLOSE   :      statestr =  "<"; break; // Connects circuit between common and input 2.
	        default		 :      statestr =  "^"; break;
	    }
        
        String text = MessageCount + ",!R" + Room + "D" + Device + "F" + statestr + "|";
        sendUDP(text);	
		}
    
    // Send on/off State to radiator TRV heating valve in Room
    public static void sendHeatOnOff(int Room, int State)
    {
    	 String statestr;
         if(State==ON) statestr = "1"; 
         		else statestr = "0";
        String text = MessageCount + ",!R" + Room + "DhF" + statestr + "|";
        sendUDP(text);
    }
    
    //Increment message counter, so different messages have different IDs
    private static void incrementMessageCount(){
    if (MessageCount <=998) MessageCount++;
    	else MessageCount = 100;
    }
   
    /*Eddie: Unfinished.  As UDP isn't guaranteed, thinking about doing a send with retry if no response UDP message received
     *... probably need to create a separate thread for a dedicated UDP listener for responses, especially for prolonged energy monitoring
    */
    /*
    public static String sendWithRetry(String Command){
    	int Count = 0;
    	String ReceivedMessage = "";
    	
    	
    	//while (Count < 5)
    	{
    		//System.out.println("Sending UDP Message:" + Command);
    		sendUDP(Command);
    		littlePause(1000);
    		ReceivedMessage = receiveUDP();
    		/*
    		if (ReceivedMessage.matches("resend")) 
    			{
    			Count++;
    			System.out.println("Resending Message " + MessageCount + "...try number " + Count);
    			}
    		else { 
    			incrementMessageCount();
    			Count=5;   	
    		 }
    		
       	}
    incrementMessageCount();

    return ReceivedMessage;
    }
    */
    
    // Initialise transmit and receive sockets for UDP
    public static void initialiseSockets(){
    	try{
    		transmitSocket = new DatagramSocket();
    		receiveSocket = new DatagramSocket(LightwavePortOut);	
    	} catch (IOException e){
    		e.printStackTrace();
    	}
    	
    }
    
    // Network sockets to deal with sending UDP commands.  Command is a UDP string specific to LighwaveRF
	public static void sendUDP(String Command){

		System.out.println("Sending UDP Message: " + Command); // Command line output to see UDP command
		
		try {
				byte[] sendData = new byte[1024];
			    sendData = Command.getBytes();
			    InetAddress IPAddress =  InetAddress.getByName(BroadcastAddress);
			    DatagramPacket sendPacket = new DatagramPacket(sendData, sendData.length, IPAddress, LightwavePortIn);
			    transmitSocket.send(sendPacket);
			    littlePause(1500);	// Wait a while so not to flood LighwaveRF box		   
			    
		} 
		catch (IOException e) {
			e.printStackTrace(); // Display if something went wrong
		}

	}
	
	//Network sockets to deal with receiving UDP responses from LightwaveRF box.  UDP response is specific to LightwaveRF
	public static String receiveUDP(){
		
		String receivedMessage = "";
		
		try {
			    byte[] receiveData = new byte[1024];
			    DatagramPacket receivePacket = new DatagramPacket(receiveData, receiveData.length);
			    receiveSocket.receive(receivePacket);
			    receivedMessage = new String(receivePacket.getData(), 0, receivePacket.getLength()); 	
			    			    	    
		} 
		catch (IOException e) {
			e.printStackTrace(); // Display if something went wrong
		}
			
	    return receivedMessage;
	    
	}

	// Simple Pause where timedelay is in milliseconds
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