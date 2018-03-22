#!/usr/bin/python3

/**
*  This class will hold all information pertaining to character,
* 	including their x and y coordinates, the symbol used to represent
* 	the character, their inventory and total credits, and the icon
* 	associated with its movement around the map
**/

using System;
using System.Collections;

namespace MissionColonizer
{
	public class Character
	{
		private int x;  // X coordinate of character
		private int y;  // Y coordinate of character
		private string characterIcon = "@"; // Character icon
		private string overTakenIcon = "!"; // Icon that is overtaken by character when moved
		private int credits = 0;    // Total money credits
		private ArrayList inventory = new ArrayList();  // Will hold everything in the players inventory
		private ArrayList plantInventory = new ArrayList();	// will hold all plants held by the player
									//TODO we will need a getter for the plants in the players inventory,
									//that will return an ArrayList

		public Character()
		{
			x = 0;
			y = 0;
		}

		public Character(int x, int y, int cr)
		{
			this.x = x;
			this.y = y;
			credits = cr;
		}

		// Update the x and y coordinates of the character
		public void setPosition(int x, int y)
		{
			// Check coordinates are inside console window
			if (x >= 0 && x < Console.WindowWidth &&
				y >= 0 && y < Console.WindowHeight)
			{
				// Undraw the current character because moving to a new position
				Undraw();
				// Set coordinates
				this.x = x;
				this.y = y;
			}
			// Check for running into left and right wall
			else if (x < 0 || x > Console.WindowWidth &&
					 y >= 0 && y < Console.WindowHeight)
			{
				Undraw();
				this.y = y;
			}
			// Check for running into top and bottom wall
			else if (x >= 0 && x < Console.WindowWidth &&
					 y < 0 || y > Console.WindowHeight)
			{
				Undraw();
				this.x = x;
			}
		}

		// Get x coord
		public int getX()
		{
			return x;
		}

		// Get y coord
		public int getY()
		{
			return y;
		}

		// Get tuple of both x and y (similar to getting a Point)
		public Tuple<int, int> getXY()
		{
			Tuple<int, int> point = new Tuple<int, int>(this.x, this.y);
			return point;
		}

		// Set the credits of the player
		public void setCredits(int cr)
		{
			credits = cr;
		}

		// Return the total credits of the character
		public int getCredits()
		{
			return credits;
		}

		// Return the players current inventory
		public ArrayList getInventory()
		{
			return inventory;
		}

		// Add things to the players inventory (tools and MRE)
		public void addToInventory(string itemToAdd)
		{
			inventory.Add(itemToAdd);
		}

		// Return the players current plant inventory
		public ArrayList getPlantInventory()
		{
			return plantInventory;
		}

		// Get the icon that the player just overrode
		public string getOvertakenIcon()
		{
			return overTakenIcon;
		}

		public void showInventory()
		{
			Console.Clear();
			Console.WriteLine("Inventory:");
			foreach (string item in inventory)
			{
				Console.WriteLine("\t" + item);
			}

			Console.WriteLine();
			Console.WriteLine("Press any key to continue..");
			Console.ReadKey();
		}

		// Update stuff in the character when moved
		public void Update()
		{
			//// Run every frame
			//// Do keyboard input stuff

			//bool hasMoved = false;

			//// Has the user pressed a key?
			//if (Console.KeyAvailable == true)
			//{
			//	ConsoleKeyInfo cki = Console.ReadKey();

			//	switch (cki.Key)
			//	{
			//		case ConsoleKey.UpArrow:
			//			setPosition(x, y - 1);
			//			hasMoved = true;
			//			break;
			//		case ConsoleKey.DownArrow:
			//			setPosition(x, y + 1);
			//			hasMoved = true;
			//			break;
			//		case ConsoleKey.LeftArrow:
			//			setPosition(x - 1, y);
			//			hasMoved = true;
			//			break;
			//		case ConsoleKey.RightArrow:
			//			setPosition(x + 1, y);
			//			hasMoved = true;
			//			break;
			//	}
			//}

			//return hasMoved;
		}

		// draw the character at their current x and y
		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(characterIcon);
		}

		// Blank out the character
		public void Undraw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(" ");
		}
	}
}
