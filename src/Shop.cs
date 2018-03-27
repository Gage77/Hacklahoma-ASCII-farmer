/**
This will handle interactionswith the shop
**/

using System;
using System.Collections;

namespace MissionColonizer
{
	public class Shop
	{
		private static int credits = 0;//will hold the amount of spending cash the player has
		private ArrayList pcPlants = new ArrayList(); //will hold all of the players plants
									//empty constructor
		public Shop()
		{
			pcPlants = new ArrayList();
		}

		//a constructor that take an int for the $$ of the player
		public Shop(int cr, ArrayList pcPlants)
		{
			credits = cr;
			this.pcPlants = pcPlants;
		}

		//this will proccess a selection, turnning an int into a item string
		public string purchase(int index)
		{
			switch (index) //checks to see what the player selected
			{
				case 1:
					Console.WriteLine("Sit tight, your shipment is on it's way colonizer!");
					//TODO makes sure it prints correctly
					return "shovel"; //makes picking up plants faster
				case 2:
					Console.WriteLine("Sit tight, your shipment is on it's way colonizer!");
					//TODO makes sure it prints correctly
					return "hoe"; //makes tilling faster
				case 3:
					Console.WriteLine("Sit tight, your shipment is on it's way colonizer!");
					//TODO makes sure it prints correctly
					return "MRE"; //foods that adds a lot to hunger 50+
				default:
					return "-1"; //returns a -1 to indicate an invalid selection
			}//end of switch
		}

		//this will create and format a string that will be used for the shop display
		public string createShopView()
		{
			string shopView = "(Your radio crackles) This is Colonial Requisition."
			+ " How can we help?\n"
			+ "1. Shovel   4. sell\n"
			+ "2. hoe      5. Exit\n"
			+ "3. MRE\n\n\n"
				+ "Your colonie's budget is: " + credits.ToString() + " Cr\n";
			return shopView;
		}

		//this will bring up and handle the sell screen
		public string createSellView()
		{
			int i = 0; //this will be use as the index for tha ArrayList
				   //this will create the first prompt line
			//int count = pcPlants.Count;
			string sellView = "Profits are the priority of all colonizers!\n";

			int k = 1; //k will count the list number
				   //this loop should move through the array printing each entry with
				   //the format 1. plant info
			//for (i, i < pcPlants.Count; i++) //NOTE is this logic correct?
			//{
			//	sellView = sellView + k.ToString() + ". " + pcPlants[i].ToString() + '\n';
			//	k++; //increment k
			//	if (k > 3) //if the player has more than 3 plants in inventory
			//{
					//make multiple pages
					//NOTE how do I
			//	}
			//}
			//appends the exit option to the end of the menu
			sellView = sellView + i.ToString() + ". Exit";
			return sellView;
		}

	}//end of class shop
}//end of namespace
