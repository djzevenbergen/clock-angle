using System;
using Clock.Models;


namespace Clock
{
  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Hey do you ever ask yourself 'I wonder how many degrees are between these gosh darn clock hands?' well friend we've got you covered. Enter an hour between 1-12:");
      int hour = int.Parse(Console.ReadLine());
      Console.WriteLine("yeah, we weren't kidding. Give us those dang minutes between 0-59");
      int minute = int.Parse(Console.ReadLine());
      double diffDegrees = (Clocks.FindDiff(hour, minute));
      Console.WriteLine("There are " + diffDegrees + " degrees between the clock hands.");
    }
  }
}