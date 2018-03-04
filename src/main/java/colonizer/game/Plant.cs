/**
The plant object will keep track of how much hunger a plant will replace
and how grow it's food is
**/

using System;

namespace MissionColonizer
{
	public class Plant
	{
		private int foodValue = 0;
		private string plantName = "This plant has not yet been named";
		private int howGrown = 0;
		private bool isFarmed = false; //TODO getters & setters
		private int price = 0; //value in store

		public Plant()
		{
			foodValue = 0;
			howGrown = 0;
			price = 10;
			plantName = "Strange Plant";
		}

		public Plant(int food, string name, int grown, int p)
		{
			foodValue = food;
			plantName = name;
			howGrown = grown;
			price = p;
		}

		public Plant harvest()
		{
			return this;
		}

		// Increase how much the plant has grown by base num (25), more if farmed
		public void growBase()
		{
			howGrown = howGrown + 25; //base growth for all plants
			if(isFarmed) //if farmed
				howGrown = howGrown + 25; //grow by a total of 50

			// check to make sure it hasn't overgrown or undergrown
			if (howGrown > 100)
				howGrown = 100;
			else if (howGrown <= 0)
				howGrown = 0;
		}

		// Return how much this plant has grown
		public int getHowGrown()
		{
			return howGrown;
		}

		// Set how much this plant has grown
		public void setHowGrown(int growth)
		{
			howGrown = growth;

			// check to make sure it hasn't overgrown or undergrown
			if (howGrown > 100)
				howGrown = 100;
			else if (howGrown <= 0)
				howGrown = 0;
		}

		// Reset the howGrown value to new value
		public void rePlant(int newHowGrown)
		{
			howGrown = newHowGrown;
			isFarmed = true;
			//TODO Might need some more stuff here
			//NOTE does a plant know where it is? Does it need to?
		}

		// Return the food value of this plant
		public int getFoodValue()
		{
			return foodValue;
		}

		// Set a new food value for this plant
		public void setFoodValue(int val)
		{
			foodValue = val;
		}

		// Return the name of this plant
		public string getPlantName()
		{
			return plantName;
		}

		// Set the name of this plant
		public void setPlantName(string name)
		{
			plantName = name;
		}

		//converts a plant into a text block
	  public string toString()
	  {
	    string info = plantName+" worth "+value+"Cr\n"
			+"nutritional value "+foodValue+"%"+'\n';
	    return info;
	  }
	}
}
