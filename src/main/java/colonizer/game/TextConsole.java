//******************************************
//
//  Console class that redirects input and output
//  a JTextArea
//
//  An output stream that writes its output to a javax.swing.JTextArea control
//******************************************

import java.io.IOException;
import java.io.OutputStream;
import javax.swing.JTextArea;

public class TextConsole extends OutputStream
{
  private JTextArea textControl;

  // Creates a new instance of TextConsole which writes to the specified
  // instance of javax.swing.JTextArea control
  public TextConsole(JTextArea control)
  {
    textControl = control;
  }

  // Writes the specified byte as a character to the Javax.swing.JTextArea
  public void write(int b) throws IOException
  {
    // Append the data as characters to the JTextArea control
    textControl.append(String.valueOf((char)b));
  }
}
