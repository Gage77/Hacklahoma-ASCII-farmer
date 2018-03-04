/**
The plant object will keep track of how much hunger a plant will replace
and how grow it's food is
**/
using System;
public class plant
{
  private int foodValue = 0; // how much hunger this plant will replace
  private string plantName = "This plant has not been named!!" // name of plant
  private int howGrown = 0; // should be between 0-100%

  //empty constructor
  public plant plant()
  {
    foodValue = 20;
    plantName = "Strange Plant";
    howGrown = 0;
  }

  //constructor
  public plant plant(int val, String name, int growth)
  {
    //sets the class varibles
    foodValue = val;
    plantName = name;
    howGrown = growth;
  }

  //harvests the plant!!
  public plant harvest()
  {
    //creates a harvest plant, that has a gorwth of zero
    Plant harvey = new Plant(foodValue, plantName, 0);
    return harvey //returns the harvest plant so that it may be added to the inventory
  }

  //growth function for non-farmed plants
  public growBase(Plant p)
  {
    p.setHowGrown(p.getHowGrown+25);
  }

  //growth function for farmed plants
  public growFarm(Plant p)
  {
    p.setHowGrown(p.getHowGrown+50);
  }

  //for when you plant your plant in new ground
  public plant rePlant(Plant harvey)
  {
    //TODO implement replanting. should pull plant from inventory
  }

  //getters/setters
  public int getFoodValue()
  {
    return foodValue;
  }

  public setFoodValue(int v)
  {
    foodValue = v;
  }

  public String getPlantName()
  {
    return plantName;
  }

  public setPlantName(String name)
  {
    plantName = name;
  }

  public int getHowGrown()
  {
    return howGrown;
  }

  public setHowGrown(int growth)
  {
    howGrown = growth;
    //ensures plant growth represents a %
    if(howGrown > 100)
      howGrown = 100;
    if(howGrown < 0)
      howGrown = 0;
  }
}
