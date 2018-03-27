#!/usr/bin/python3

/**
*  The Game class will hold all information pertaining to the currently
* 	loaded game, including the player character and the map. It will also
* 	serve to make update calls so as to force the redrawing of the scene, which
* 	is done in the Run() method.
**/

using System;
using System.IO;

namespace MissionColonizer
{
	public class Game
	{
		private Character player;
		private Map map;

		// Create a new game
		public Game()
		{
			player = new Character(10, 10);
			map = new Map(player);

			// Print test map to console
			StreamReader sr = new StreamReader("../../alphaMap.txt");
			string line = sr.ReadLine();
			while (line != null)
			{
				Console.WriteLine(line);
				line = sr.ReadLine();
			}
		}

		// Run the game
		public void Run()
		{
			// Infinite game loop
			while (true)
			{
				// Update map and player
				player.Update();

				// Draw updated objects
				player.Draw();
			}
		}
	}
}
