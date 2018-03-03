/**
*  This class will hold all information pertaining to character
**/

import java.awt.*;
import java.util.*;

public class Character
{
  private ArrayList<String> inventory;
  private int hunger;
  private Point location;

  public Character()
  {
    hunger = 100;
    location = new Point(0, 0);
    inventory = new ArrayList<String>();
  }

  public Character(int hunger, int x, int y)
  {
    this.hunger = hunger;
    this.location = new Point(x, y);
  }

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
}
