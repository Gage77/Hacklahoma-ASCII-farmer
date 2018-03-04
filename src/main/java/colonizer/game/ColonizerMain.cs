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
* @version 0.85
*
**************************
* Last Edited:
**************************
*
************************************/

using System;   // imports standard .NET library
using System.IO;

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

			while (menuDecision != 3)
			{
				// Print out main page again if help was just accessed
				if (menuDecision == 5)
				{
					sr = new StreamReader("../../titleMenu.txt");
					line = sr.ReadLine();
					while (line != null)
					{
						Console.WriteLine(line);
						line = sr.ReadLine();
					}
				}

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
						displayHelp();
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

		static void displayHelp()
		{
			Console.Clear();

			// Show help page
			StreamReader sr = new StreamReader("../../helpPage.txt");
			string line = sr.ReadLine();
			while (line != null)
			{
				Console.WriteLine(line);
				line = sr.ReadLine();
			}

			Console.ReadKey();
			Console.Clear();
		}
	}
}
