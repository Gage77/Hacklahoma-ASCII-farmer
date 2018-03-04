/**
*  The map will be responsible for managinf a single "square"in the grid of
*  squares that will form the map. It will manage the biomes, plants, farms,
*  character location (within the square), and the valid exits (via a setter.getter).
**/

using System;

public class Map
{
  //private varibles
  //the biomes of the square
  private ArrrayList<String> biomes = new ArrrayList<String>();
  //the unfarmed plants in the square
  private ArrrayList<Plant> plants = new ArrrayList<Plant>();
  //the farmed/alter plants in the square
  private ArrrayList<String> farms = new ArrrayList<String>();
  //character location within the square
  private String characterLocation = "-1";
  //holds all of the plant locations
  private dictonary plantValues;

  public static map()
  {
    //TODO write, and find way to fill dictonary
  }

  //grows all the plants on the map
  public static void grow()
  {
    //TODO change when we implement biomes
    foreach (Plant thing in plants)
    {
      thing.growBase(thing);
    }
  }

  //draws/update the HUD
  public static string drawHud(int x, int y, char c)
  {
    string hud = "X coordinate = "+ x.ToString + " Y coordinate = "
    +y.ToString + getLocationInfo(x, y, c);
    return hud;
  }

  //gets the info for the position of the player
  public static string getLocationInfo(int x, int y, char c)
  {
    //if the coordinate holds a plant, return the plant
    if(plantValues.ContainsKey(int.Parse(x.ToString() + y.ToString()))
      return plantValues[int.Parse(x.ToString() + y.ToString().toString];
    //otherwise return the terrian type
    else
    {
      if(c == '^')
        return "mountain";
      if(c == 'W')
        return "water"
      if(c == 'O')
        return "Ice"
    };
  }

  //sets the biome
  public static void setBiome(ArrrayList<String> b)
  {
    biomes = b;
  }

  //gets the biome
  public static ArrrayList<String> getBiome()
  {
    return biomes;
  }

  //gets the character character
  public static int getCharacterLocation()
  {
    return characterLocation;
  }

}
