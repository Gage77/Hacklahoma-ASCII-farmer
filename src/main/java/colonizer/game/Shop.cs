/**
This will handle interactionswith the shop
**/

using System;

namespace MissionColonizer
{
  public class shop
  {
    private int credits =0;//will hold the amount of spending cash the player has
    private ArrayList pcPlants; //will hold all of the players plants
    //empty constructor
    public static void shop()
    {
        pcPlants = null;
    }

    //a constructor that take an int for the $$ of the player
    public static void shop(int credits, ArrayList pcPlants)
    {
        this.credits = credits;
        this.pcPlants = pcPlants;
    }

    //This will take a number representing what a player selected.
    //It will then return a string representing their pruchase
    public static string purchase(int index)
    {
      //NOTE does this allow for multiple things to be bought?
      switch (index) //checks to see what the player selected
      {
          case 1:
              Console.WriteLine("Sit tight, your shipment is on it's way colonizer!"); 
              //TODO makes sure it prints correctly
              return "shovel"; //makes picking up plants faster
              break;
          case 2:
              Console.WriteLine("Sit tight, your shipment is on it's way colonizer!");
              //TODO makes sure it prints correctly
              return "hoe"; //makes tilling faster
              break;
          case 3:
              Console.WriteLine("Sit tight, your shipment is on it's way colonizer!");
              //TODO makes sure it prints correctly
              return "MRE" //foods that adds a lot to hunger 50+
              break;
          default:
              return "-1"; //returns a -1 to indicate an invalid selection
              break;
      }//end of switch
    }

    //this will create and format a string that will be used for the shop display
    public static string createShopView()
    {
      string shopView = "(Your radio crackles) This is Colonial Requisition."
      +" How can we help?\n"
      +"1. Shovel   4. sell\n"
      +"2. hoe      5. Exit\n"
      +"3. MRE\n"
      +"Your colonie's budget is: "+credits.ToString+"Cr";
      return shopView;
    }

    //this will bring up and handle the sell screen
    public static int createSellView()
    {

    }

  }//end of class shop
}//end of namespace
