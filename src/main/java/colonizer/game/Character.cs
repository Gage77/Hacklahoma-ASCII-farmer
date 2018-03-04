/**
*  This class will hold all information pertaining to character,
* 	including their x and y coordinates, the symbol used to represent
* 	the character, their inventory and total credits, and the icon
* 	associated with its movement around the map
**/

using System;

namespace MissionColonizer
{
	public class Character
	{
		private int x;	// X coordinate of character
		private int y;	// Y coordinate of character
		private string characterIcon = "@";	// Character icon
		private string overTakenIcon = "!";	// Icon that is overtaken by character when moved
		private int credits = 0;	// Total money credits
		//TODO we will need a getter for the plants in the players inventory,
		//that will return an ArrayList 

		public Character()
		{
			x = 0;
			y = 0;
		}

		public Character(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

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
			else if (x < 0 || x > Console.WindowWidth &&
					 y >= 0 && y < Console.WindowHeight)
			{
				Undraw();
				this.y = y;
			}
			else if (x >= 0 && x < Console.WindowWidth &&
					 y < 0 || y > Console.WindowHeight)
			{
				Undraw();
				this.x = x;
			}
		}

		public int getX()
		{
			return x;
		}

		public int getY()
		{
			return y;
		}

		public Tuple<int, int> getXY()
		{
			Tuple<int, int> point = new Tuple<int, int>(this.x, this.y);
			return point;
		}

		public string getOvertakenIcon()
		{
			return overTakenIcon;
		}

		public void Update()
		{
			// Run every frame

			// Do keyboard input stuff

			// Has the user pressed a key?
			if (Console.KeyAvailable == true)
			{
				ConsoleKeyInfo cki = Console.ReadKey();

				switch (cki.Key)
				{
					case ConsoleKey.UpArrow:
						setPosition(x, y - 1);
						break;
					case ConsoleKey.DownArrow:
						setPosition(x, y + 1);
						break;
					case ConsoleKey.LeftArrow:
						setPosition(x - 1, y);
						break;
					case ConsoleKey.RightArrow:
						setPosition(x + 1, y);
						break;
				}
			}
		}

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(characterIcon);
		}

		public void Undraw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(" ");
		}

	}
}
