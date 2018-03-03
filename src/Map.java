/**
*  The map will be responsible for managinf a single "square"in the grid of
*  squares that will form the map. It will manage the biomes, plants, farms,
*  character location (within the square), and the valid exits (via a setter.getter).
**/

import java.util.*;

public map()
{
  //private varibles
  //the biomes of the square
  private ArrrayList<String> biomes = new ArrrayList<String>();
  //the unfarmed plants in the square
  private ArrrayList<String> plants = new ArrrayList<String>();
  //the farmed/alter plants in the square
  private ArrrayList<String> farms = new ArrrayList<String>();
  //character location within the square
  private String characterLocation = "-1";
  //hold the valid exit 1 = valid, North, South, East, West
  private int validExits = 1111;

  //grows all the plants on the map
  public static void grow()
  {
    //TODO
  }

  //draws/update the HUD
  public static void drawHud()
  {
    //TODO
  }

  //gets the info for the position of the player
  public static String getLocationInfo()
  {
    //TODO
  }

  //sets the value of the exits
  public static void setExits(exits a)
  {
    validExits = a;
  }

  //sets the valid exits
  public static int getExits()
  {
    return validExits;
  }

  //sets the biome
  public static void setBiome(ArrrayList<String> b)
  {
    biomes = b;
  }

  //gets the biome
  public static ArrrayList<String>() getBiome()
  {
    return biomes;
  }

  //gets the character character
  public static int getCharacterLocation()
  {
    return characterLocation;
  }


}
