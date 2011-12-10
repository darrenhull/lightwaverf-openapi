/*
 * Basic logging to text file.  Operation is open, log, close.
 */

package com.Lightwave;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.PrintStream;


public class LogToCSV {
	
	public static PrintStream out; 

	//Open File to output to
	public static void openFile(String filename){
		
		String m_filename = filename;
		  try {
		      		out = new PrintStream(new FileOutputStream(m_filename));
		      		System.out.println("---LOG: Logging file opened.");
		    } catch (FileNotFoundException e) {
		      e.printStackTrace();
		    }
	}
	
	//Close file that has output
	public static void closeFile(){
		  try {
		      		out.close();
		      		System.out.println("---LOG: Logging file closed.");

		    } catch (Exception e) {
		      e.printStackTrace();
		    }
	}
	
	/* Take text entry and log it to an open file.
		String logEntry - any text to be logged.  Preferably CSV.
	*/
	
	public static void logData(String logEntry){
	   try {
	
		     out.println(logEntry);
	      	 System.out.println("---LOG: Logging entry to file.");

		    } catch (Exception e) {
		      e.printStackTrace();
		    }
		  }
	
}
