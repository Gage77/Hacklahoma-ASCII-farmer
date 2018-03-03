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
import java.awt.*;
import javax.swing.*;

public final class Colonizer
{
  final static int WINDOW_DIMENSIONS = 600;
  final static int WINDOW_POSITION = 50;

  public static void main(String[] args)
  {
    JFrame mainFrame = new JFrame("Mission: Colonizer");
    JPanel mainPanel = new JPanel();

    mainFrame.setBounds(WINDOW_POSITION, WINDOW_POSITION, WINDOW_DIMENSIONS, WINDOW_DIMENSIONS);
    mainFrame.getContentPane().setLayout(new BorderLayout());
    mainFrame.getContentPane().add(mainPanel, BorderLayout.CENTER);
    mainFrame.setVisible(true);
		mainFrame.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);

    System.out.println("test");
  }
}
