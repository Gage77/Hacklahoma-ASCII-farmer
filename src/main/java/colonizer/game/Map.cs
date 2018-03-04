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
using System.IO;

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

		private Character pc;   // Player character object

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

			StreamReader sr = new StreamReader("../../alphaMap.txt");
			string line = sr.ReadLine();
			while (line != null)
			{
				Console.WriteLine(line);
				line = sr.ReadLine();
			}
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
					case ConsoleKey.R:
						string shopView = "";
						doShopThings(pc, shopView);
						Draw();
						break;
					case ConsoleKey.I:
						pc.showInventory();
						break;
					case ConsoleKey.Escape:
						Environment.Exit(0);
						break;
				}
			}

			return hasMoved;
		}

		public void doShopThings(Character pc, string shopView)
		{
			int userInput = 0;
			string purchasedString = "";

			while (userInput != 5)
			{
				Shop shop = new Shop(pc.getCredits(), pc.getInventory());
				shopView = shop.createShopView();

				Console.Clear();
				Console.Write(shopView);

				Console.WriteLine(purchasedString);

				ConsoleKeyInfo cki = Console.ReadKey();

				switch (cki.Key)
				{
					case ConsoleKey.D1:
						userInput = 1;
						if (pc.getCredits() >= 10)
						{
							purchasedString = "Hold tight, your shipment is on its way...\nPurchased shovel!";
							// Decrement character's credits
							pc.setCredits(pc.getCredits() - 10);
							pc.addToInventory("Shovel");
						}
						else
						{
							purchasedString = "You don't have enough credits to purchase that.\n";
						}
						break;
					case ConsoleKey.D2:
						userInput = 2;
						if (pc.getCredits() >= 10)
						{
							purchasedString = "Hold tight, your shipment is on its way...\nPurchased hoe!";
							// Decrement character's credits
							pc.setCredits(pc.getCredits() - 10);
							pc.addToInventory("Hoe");
						}
						else
						{
							purchasedString = "You don't have enough credits to purchase that.\n";
						}
						break;
					case ConsoleKey.D3:
						userInput = 3;
						if (pc.getCredits() >= 20)
						{
							purchasedString = "Hold tight, your shipment is on its way...\nPurchased MRE!";
							// Decrement character's credits
							pc.setCredits(pc.getCredits() - 20);
							pc.addToInventory("MRE");
						}
						else
						{
							purchasedString = "You don't have enough credits to purchase that.\n";
						}
						break;
					case ConsoleKey.D4:
						userInput = 4;
						break;
					case ConsoleKey.D5:
						userInput = 5;
						break;
				}

				//TODO add purchased item to inventory
			}

			Console.Clear();
		}

		public void Draw()
		{
			Console.Clear();
			// Print test map to console
			StreamReader sr = new StreamReader("../../alphaMap.txt");
			string line = sr.ReadLine();
			while (line != null)
			{
				Console.WriteLine(line);
				line = sr.ReadLine();
			}
		}
	}
}
