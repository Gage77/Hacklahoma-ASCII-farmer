/************************************
* Mission: Colonizer
**************************
*
**************************
* Modificatoin History:
*   C# switch
**************************
*
* @author Conner Flansberg, Hunter Black
* @version 0.3
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

using System;   // imports standard .NET library
using System.IO;	// imports standard system input/output (file readers and streams)

namespace MissionColonizer
{
	static class Globals
	{
		public static string planetName = "";
	}

	class ColonizerMain
	{
		public string planetName = "ABC123";

		static void Main()
		{
			// Hide blinking cursor
			Console.CursorVisible = false;

			// Hold input value for start menu
			int menuDecision = 0;

			// Show start menu
			StreamReader sr = new StreamReader("../../titleMenu.txt");
			string line = sr.ReadLine();
			while (line != null)
			{
				Console.WriteLine(line);
				line = sr.ReadLine();
			}

			while (menuDecision == 0)
			{
				ConsoleKeyInfo cki = Console.ReadKey();

				switch (cki.Key)
				{
					case ConsoleKey.D1:	// New Game
						menuDecision = 1;
						createGame();
						break;
					case ConsoleKey.D2: // Load
						menuDecision = 2;
						break;
					case ConsoleKey.D3: // Exit
						menuDecision = 3;
						Environment.Exit(0);
						break;
					case ConsoleKey.D4: // Donate
						menuDecision = 4;
						break;
					case ConsoleKey.D5: // Help
						menuDecision = 5;
						break;
				}
			}

			// Program end
			// Do cleanup

			// Set cursor to bottom of screen
			Console.SetCursorPosition(
				0,
				Console.WindowHeight - 1);
		}

		static void createGame()
		{
			Console.Clear();

			StreamReader sr = new StreamReader("../../introBlurb.txt");
			string line = sr.ReadLine();
			while (line != null)
			{
				Console.WriteLine(line);
				line = sr.ReadLine();
			}
			Console.WriteLine();
			Console.WriteLine("You have been assigned to planet: (Enter planet name) \n");

			Globals.planetName = Console.ReadLine();

			Console.WriteLine("Planet name designation: " + Globals.planetName + "\n");

			Console.WriteLine("Your dropship will leaves in 30 minutes. \nGoodluck, traveler!\n");

			System.Threading.Thread.Sleep(5000);

			Console.Clear();

			Game game = new Game();
			game.Run();
		}
	}
}
