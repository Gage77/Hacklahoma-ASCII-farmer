/**
  This class will create the player cursor
**/
import java.util.*;
import java.swing.*;

public playerCursor extends DefaultCaret()
{
  //set the character for the caret
  private String mark = "@";

  //creates the player icon
  public playerCursor
  {
      setBlinkRate(500);
  }

}
