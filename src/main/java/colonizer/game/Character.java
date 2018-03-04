/**
*  This class will hold all information pertaining to character
**/

using System;

public class Character
{
  //this will store the player inventory
  private String [] inventory;
  //the value (0-100) of the players hunger
  private int hunger;
  //the point of the character's location
  private Point location;

  //constructor
  public Character()
  {
    hunger = 100;
    location = new Point(0, 0);
    String [] inventory = new String[3];
  }

  //constructor
  public Character(int hunger, int x, int y)
  {
    this.hunger = hunger;
    this.location = new Point(x, y);
    String [] inventory = new String[3];
  }

  //this will create the string for player HUD
  public String createHud ()
  {
    String hud = new String("Inventory: "+ "\n"
    +"1.Tools  2.Base 3.Food  "+ "\n"
    +"Hunger Level "+ hunger+"%");
    return hud;
  }

  //getters & setters

  public int getHunger()
  {
    return hunger;
  }

  public Point getLocation()
  {
    return location;
  }

  public void setHunger(int hunger)
  {
    // Set hunger of character
    this.hunger = hunger;

    // Check for overloaded hunger or no hunger
    if (this.hunger > 100)
      setHunger(100);
    else if (this.hunger < 0)
      setHunger(0);
  }

  public void setLocation(int x, int y)
  {
    location.setLocation(x, y);
  }

  public String [] getInventory()
  {
    return inventory;
  }

  public void addInventory(String item)
  {
    if(item.Contains("tool"))
      inventory[1].concat(item);

    if(item.Contains("base"))
      inventory[2].concat(item);

    if(item.Contains("food"))
      inventory[3].concat(item);
  }
}
