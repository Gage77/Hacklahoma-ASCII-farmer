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
  public static string drawHud(int x, int y)
  {
    return getLocation(x, y);
  }

  //gets the info for the position of the player
  public static string getLocationInfo(int x, y)
  {
    //TODO how do we determine this?
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
