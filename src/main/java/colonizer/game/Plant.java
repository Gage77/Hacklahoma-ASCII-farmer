/**
The plant object will keep track of how much hunger a plant will replace
and how grow it's food is
**/

//TODO some how makes sure all plants are all added to dictonary in map
using System;
public class plant
{
  private int foodValue = 0; // how much hunger this plant will replace
  private string plantName = "This plant has not been named!!" // name of plant
  private int howGrown = 0; // should be between 0-100%
  private Point location;
  private int xCoord; //this will hold the plants x coordinate
  private int yCoord; //this will hold the plants y coordinate
  private int value = 0; //the value of the plant at the store

  //empty constructor DO NOT USE
  public plant plant()
  {
    foodValue = 20;
    plantName = "Strange Plant";
    howGrown = 0;
  }

  //constructor
  public plant plant(int val, int price, String name, int growth, Point loc)
  {
    //sets the class varibles
    foodValue = val;
    plantName = name;
    howGrown = growth;
    location = loc;
    value = price;
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

  //NOTE for when you plant your plant in new ground. This should be done in map so
  //that the dictionary can be updated
  public plant rePlant(Plant harvey, Point location)
  {
    harvey.setLocation(location);
    return harvey;
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

  public int getValue()
  {
      return value;
  }

  public void setValue(int p)
  {
    value = p;
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

  public Point getLocation()
  {
    return location;
  }

  public Point setLocation(Point p)
  {
    location = p;
  }
  //converts a plant into a text block
  public string toString()
  {
    string hud = "position: "+xCoord.ToString()+" by "+yCoord.ToString()+'\n'
    +plantName+" worth "+value+'\n'+"nutritional value "+foodValue+"%"+'\n'
    +howGrown+"% grown";
    return hud;
  }
}
