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
  final static int WINDOW_DIMENSIONS = 600;
  final static int WINDOW_POSITION = 50;

  public static void main(String[] args)
  {
    JFrame frame = new JFrame();
    frame.add( new JLabel("Colonizer" ), BorderLayout.NORTH );

    Font consoleFont = new Font("Courier New", Font.BOLD, 20);
    JTextArea txtConsole = new JTextArea();
    txtConsole.setBackground(Color.BLACK);
    txtConsole.setForeground(Color.WHITE);
    txtConsole.setFont(consoleFont);

    PrintStream out = new PrintStream(new TextConsole(txtConsole));

    System.setOut(out);
    System.setErr(out);

    frame.add(txtConsole);

    frame.pack();
    frame.setVisible(true);
    frame.setSize(800,600);

    System.out.println("TEST TEXT");
  }
}
