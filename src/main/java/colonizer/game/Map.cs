/**
*  The map will be responsible for managinf a single "square"in the grid of
*  squares that will form the map. It will manage the biomes, plants, farms,
*  character location (within the square), and the valid exits (via a setter.getter).
**/

//NOTE plants harvested and store in player inventory must disappear from the
// dictinary, and then be added at thier new position when planted

using System;
using System.Collections;
using System.Collections.Generic;

namespace MissionColonizer
{
	public class Map
	{
		ArrayList biomes = new ArrayList(); // Biomes of the square
		ArrayList plants = new ArrayList(); // Unfarmed plants in the square
		ArrayList farms = new ArrayList();  // Farmed/altered plants in the square

		private int characterLocationX = 0;    // Character location of x coord
		private int characterLocationY = 0;
		// Plant locations, int is the Tuple in character
		private Dictionary<int, Plant> plantValues = new Dictionary<int, Plant>();

		private Character pc;   // Player character object

		public Map()
		{
			characterLocationX = 0;
			characterLocationY = 0;

			//TODO read map file, and store location of all plants
		}

		public Map(Character pc)
		{
			this.pc = pc;
			characterLocationX = pc.getXY().Item1;
			characterLocationY = pc.getXY().Item2;
		}

		//will grow all plants in plantValues
		public void grow()
		{
			foreach (Plant key in plants.Keys.ToList()) //move over all entries
			{
    		vector[key].growBase(); //preform grow on this entry
			}
			//TODO change when we implement biomes
		}

		// x y coord of player's current position, and current ascii char
		public string drawHud(int x, int y, char c)
		{
			string hud = "X coord: " + x.ToString() + ", Y coord: " + y.ToString();
			hud = hud + getLocationInfo(x, y, c);
			return hud;
		}

		// x y coord of current pos, and ascii char of current space
		public string getLocationInfo(int x, int y, char c)
		{

			if (c == '^')
				return "Mountains";
			else if (c == 'W')
				return "Water";
			else if (c == 'O')
				return "Ice";

			return "Grasslands";
		}

		// this may not be necessary, as we are already storing the x and y
		// coords of the character in the map object
		//public static int getCharacterLocation()
		//{
		//	return 0;
		//}

		public void setBiome(ArrayList b)
		{
			biomes = b;
		}

		public ArrayList getBiome()
		{
			return biomes;
		}

		public bool Update(Character pc)
		{
			// Run every frame
			// Do keyboard input stuff

			bool hasMoved = false;

			// Has the user pressed a key?
			if (Console.KeyAvailable == true)
			{
				ConsoleKeyInfo cki = Console.ReadKey();

				switch (cki.Key)
				{
					case ConsoleKey.UpArrow:
						pc.setPosition(pc.getX(), pc.getY() - 1);
						hasMoved = true;
						break;
					case ConsoleKey.DownArrow:
						pc.setPosition(pc.getX(), pc.getY() + 1);
						hasMoved = true;
						break;
					case ConsoleKey.LeftArrow:
						pc.setPosition(pc.getX() - 1, pc.getY());
						hasMoved = true;
						break;
					case ConsoleKey.RightArrow:
						pc.setPosition(pc.getX() + 1, pc.getY());
						hasMoved = true;
						break;
				}
			}

			return hasMoved;
		}

		public void Draw()
		{

		}
	}
}
