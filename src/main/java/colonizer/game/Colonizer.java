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

    // Start startMenu
    startMenu();

    // Pack and set frame to visible
    mainFrame.pack();
    mainFrame.setExtendedState(JFrame.MAXIMIZED_BOTH);  // Set application to maximize in screen
    mainFrame.setVisible(true);
    //TODO !!!test!!! Do we want to make the map an open file rather than a string?
    try {
            //buffer to read in our map file
            BufferedReader buff = new BufferedReader(new FileReader(map.txt));
            //reads a file into the JTextArea. Currently this only reads a single map
            txtConsole.read(buff, "map.txt");


            /*//reads the entire file
            while((line = buff.readLine()) != null) {
                //concats the file into one large string
                mapString = mapString.concat(line);
            }
            buff.close();**/

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

    //String testMap = "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm\n"
    //+ "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm\n"
    //+ "mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm\n";
    //System.out.print(testMap);
  }

  private static void startMenu()
  {
    JFrame startMenuFrame = new JFrame("Missions: Conolizer");
    JPanel startMenu = new JPanel();
    startMenu.setLayout(new BoxLayout(startMenu, BoxLayout.LINE_AXIS));

    JButton startButton = new JButton("Start");
    JButton quitButton = new JButton("Quit");

    startMenu.add(startButton);
    startMenu.add(quitButton);

    startMenuFrame.getContentPane().add(startMenu);

    startMenuFrame.pack();
    startMenuFrame.setExtendedState(JFrame.MAXIMIZED_BOTH);  // Set application to maximize in screen
    startMenuFrame.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
    startMenuFrame.setVisible(true);
  }

  public static String readFile(String fileName)
  {
    try {
      BufferedReader br = new BufferedReader(new FileReader(fileName));
      StringBuilder sb = new StringBuilder();
      String line = br.readLine();

        while ((line = br.readLine()) != null) {
            sb.append(line);
            sb.append("\n");
            line = br.readLine();
        }
      br.close();
      return sb.toString();
    } catch (IOException e1) {
      e1.printStackTrace();
    }
    return "NULL";
  }
}
