/**
  This class will create the player cursor
**/
import java.util.*;
import javax.swing.*;

public class playerCursor extends DefaultCaret
{
  //set the character for the caret
  private String mark = "@";

  //creates the player icon
  public playerCursor()
  {
      setBlinkRate(500);
  }

}
