package com.Lightwave;

import java.io.IOException;
import java.io.BufferedReader;
import java.io.InputStreamReader;

/*
 * Command line console runs in own thread, to allow direct input of UDP in command line
 * Response of send and receive will be logged in console window.
 * Can be run together with other commands and sequences.
 * 
 */
public class Console extends Thread {
	
	private static SendUDP m_sender; // Sever object for buffering and sending UDP requests to LWRF box

	/*
	 * Constructor.
	 */
	public Console(SendUDP sender){
		m_sender=sender; // UDP Server to send commands to
		System.out.println("Enter raw UDP commands e.g. @?  :");  // Prompt
		start();
	}
	

	/*
	 * Do the polling task with this thread running in background
	 * (non-Javadoc)
	 * @see java.lang.Thread#run()
	 */

	  public void run() {
		    while(true) {
		    	GetCommandLine(); //Get some command line input
		    }
		  }
/*
 * Get command line input from console and send UDP string to the UDP server for sending to LWRF wifi box
 * Format of UDP command is raw: e.g. !R1D1F1
 * 	  
 */
	  public static void GetCommandLine(){
		  try {
			   InputStreamReader isr = new InputStreamReader(System.in); // Get input from console
			      BufferedReader br = new BufferedReader(isr); // Buffer input
			      String s = br.readLine(); // Read input from console after CR entered
			      m_sender.sendUDP("," + s ); // Prepend command with comma.    
		} catch (IOException e) {
			e.printStackTrace();
		}
	  }
	  
}
