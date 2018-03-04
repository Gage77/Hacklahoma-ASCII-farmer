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

		public Plant()
		{
			foodValue = 0;
			howGrown = 0;
			plantName = "Strange Plant";
		}

		public Plant(int food, string name, int grown)
		{
			foodValue = food;
			plantName = name;
			howGrown = grown;
		}

		public Plant harvest()
		{
			return this;
		}

		// Increase how much the plant has grown by base num (50)
		public void growBase()
		{
			howGrown = howGrown + 50;

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
			//TODO Might need some more stuff here
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
	}
}
