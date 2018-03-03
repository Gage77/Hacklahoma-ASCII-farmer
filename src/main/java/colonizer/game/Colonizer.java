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
* @version 0.1
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
//    GridView (Created by map, the main window of the applcation, handled by MapManager)
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

public final class Colonizer
{
  // Main method
  public static void main(String[] args)
  {
    // Setup game window
    createGameWindow();


    System.out.println("TEST TEXT");
  }

  // Create the main window for the game, as well as the adjusted
  // JTextArea for output streaming
  public static void createGameWindow()
  {
    // Create JFrame and JTextArea
    JFrame frame = new JFrame("Mission: Colonizer");
    JTextArea txtConsole = new JTextArea();

    // Setup stuff to make the JTextArea look like a console
    Font consoleFont = new Font("Courier New", Font.BOLD, 20);
    txtConsole.setBackground(Color.BLACK);  // Sets background to black
    txtConsole.setForeground(Color.WHITE);  // Makes the foreground (text) white
    txtConsole.setFont(consoleFont);  // Adds the font to the JTextArea

    // Establish a new output stream for System.out, making it go to JTextArea
    PrintStream out = new PrintStream(new TextConsole(txtConsole));
    System.setOut(out); // Set standard out to follow new PrintStream
    System.setErr(out); // Set standard error to follow new PrintStream

    // Add the JTextArea to the JFrame frame
    frame.add(txtConsole);

    // Pack and set frame to visible
    frame.pack();
    frame.setExtendedState(JFrame.MAXIMIZED_BOTH);  // Set application to maximize in screen
    frame.setVisible(true);
  }
}
