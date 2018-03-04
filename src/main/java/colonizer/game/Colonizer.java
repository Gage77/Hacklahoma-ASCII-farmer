/************************************
* Mission: Colonizer
**************************
*
**************************
* Modificatoin History:
*   Initial
**************************
*
* @author Conner Flansberg, Hunter Black
* @version 0.28
*
**************************
* Last Edited:
**************************
*
************************************/


//******************************************
// Objects needed:
//    MapManager (create the maps, and update the maps, and HUD) (view)
//    Map (model, stores info on the map)
//
//    Character (values for inventory, hunger values)
//    CharacterManager (handles movment and interaction)
//
//    TimeMangager (handles clock and day/night cycle, gets values from
//                character and map, and effects plant growth, only get time)
//
//    Shop (handles shop interaction)
//
//    Plant (created by the Map, hold data on plants such as ID, grow time, hunger value)
//
//    Note will be separate or open native text editor, or something similar
//        OR open a text box that reads and writes to a txt file associated with the save
//
//    BaseManager (manages Base objects and interaction with base objects)
//    Base  (holds information on base stuff)
//******************************************

import java.util.*;
import java.lang.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public final class Colonizer
{
  private static JFrame mainFrame = new JFrame("Missions: Colonizer");
  private static JTextArea txtConsole = new JTextArea();

  private static char csym = '@';

  private static int menuSelection = 0;

  // Main method
  public static void main(String[] args)
  {
    // Setup stuff to make the JTextArea look like a console
    Font consoleFont = new Font("Courier New", Font.BOLD, 20);
    txtConsole.setBackground(Color.BLACK);  // Sets background to black
    txtConsole.setForeground(Color.WHITE);  // Makes the foreground (text) white
    txtConsole.setFont(consoleFont);  // Adds the font to the JTextArea
    txtConsole.setEditable(false); //prevents users from editing the map
    //sets the caret to the insert mode
    txtConsole.getCaret().setBlinkRate(2000);//sets the blink rate of the caret to 2 a second

    // Establish a new output stream for System.out, making it go to JTextArea
    PrintStream out = new PrintStream(new TextConsole(txtConsole));
    System.setOut(out); // Set standard out to follow new PrintStream
    System.setErr(out); // Set standard error to follow new PrintStream

    // Add the JTextArea to the JFrame frame
    mainFrame.add(txtConsole);

    // Create keyboard listener for JTextArea
    txtConsole.addKeyListener(new KeyListener() {
      @Override
      public void keyPressed(KeyEvent e)
      {
        System.out.println("Key pressed: " + e.getKeyChar());
      }
      @Override
      public void keyReleased(KeyEvent e)
      {
        System.out.println("Key released: " + e.getKeyChar());
      }
      @Override
      public void keyTyped(KeyEvent e)
      {
        System.out.println("Key typed: " + e.getKeyChar());
      }
    });

    // Pack and set frame to visible
    mainFrame.pack();
    mainFrame.setExtendedState(JFrame.MAXIMIZED_BOTH);  // Set application to maximize in screen
    mainFrame.setVisible(true);

    // Read in title ascii art
    //BUG Not printing title file
    try {
            //buffer to read in our map file
            BufferedReader buff = new BufferedReader(new FileReader("asciiTitle.txt"));
            //reads a file into the JTextArea. Currently this only reads a single map
            txtConsole.read(buff, "asciiTitle.txt");

            //TODO when do we close the file map.txt? On a save only?
        }//end try
        catch(FileNotFoundException e) {
          e.printStackTrace();
        }//end FileNotFoundException
        catch(IOException e) {
          e.printStackTrace();
        }//end IOException
        finally{
    };

    // while(menuSelection == 0)
    // {
    //
    // }

    //TODO !!!test!!! Do we want to make the map an open file rather than a string?
    try {
            //buffer to read in our map file
            BufferedReader buff = new BufferedReader(new FileReader("testMap.txt"));
            //reads a file into the JTextArea. Currently this only reads a single map
            txtConsole.read(buff, "testMap.txt");

            //TODO when do we close the file map.txt? On a save only?
        }//end try
        catch(FileNotFoundException e) {
          e.printStackTrace();
        }//end FileNotFoundException
        catch(IOException e) {
          e.printStackTrace();
        }//end IOException
        finally{
    };

    System.out.println(txtConsole.getText());
  }
}
