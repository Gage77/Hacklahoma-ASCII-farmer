/**
*  The map will be responsible for managinf a single "square"in the grid of
*  squares that will form the map. It will manage the biomes, plants, farms,
*  character location (within the square), and the valid exits (via a setter.getter).
**/

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
		private Dictionary<int, Plant> plantValues = new Dictionary<int, Plant>();  // Plant locations

		private Character pc;	// Player character object

		public Map()
		{
			characterLocationX = 0;
			characterLocationY = 0;

			//TODO Find way to fill dictinary
		}

		public Map(Character pc)
		{
			this.pc = pc;
			characterLocationX = pc.getXY().Item1;
			characterLocationY = pc.getXY().Item2;
		}

		public void grow()
		{
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

		public void Update()
		{

		}

		public void Draw()
		{

		}
	}
}
