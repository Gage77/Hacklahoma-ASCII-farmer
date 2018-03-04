/**
This will handle interactionswith the shop
**/

using System;

namespace MissionColonizer
{
  public class shop
  {
    private int credits = 0;//will hold the amount of spending cash the player has
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

    //this will proccess a selection, turnning an int into a item string
    public static string purchase(int index)
    {
      switch (index) //checks to see what the player selected
      {
          case 1:
              return "shovel"; //makes picking up plants faster
              break;
          case 2:
              return "hoe"; //makes tilling faster
              break;
          case 3:
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
    public static string createSellView()
    {
        int index i //this will be use as the index for tha ArrayList
        //this will create the first prompt line
        string sellView = "Profits are the priority of all colonizers!\n"
        int k = 1; //k will count the list number
        //this loop should move through the array printing each entry with
        //the format 1. plant info
        for(i=0, i < pcPlants.length; i++)
        {
          sellView = sellView + k.ToString+". "+pcPlants[i].toString+'\n';
          k++; //increment k
        }
            //appends the exit option to the end of the menu
            sellView = sellView+i.ToString+". Exit";
    }

  }//end of class shop
}//end of namespace
