using System;

class Clock
{
  static void Main()
  {
    Console.WriteLine("Hey do you ever ask yourself 'I wonder how many degrees are between these gosh darn clock hands?' well friend we've got you covered. Enter an hour between 1-12:");
    int hour = int.Parse(Console.ReadLine());

    Console.WriteLine("yeah, we weren't kidding. Give us those dang minutes between 0-59");
    int minute = int.Parse(Console.ReadLine());

    double diffDegrees = (FindDiff(hour, minute));

    Console.WriteLine("There are " + diffDegrees + " degrees between the clock hands.");
  }
  static double HoursDegrees(int hour, int minute)
  {
    double hourDeg = ((30 * hour) + (0.5 * minute));
    Console.WriteLine(hourDeg);
    return hourDeg;
  }
  static int MinutesDegrees(int minute)
  {
    int minDeg = (minute * 6);
    Console.WriteLine(minDeg);
    return minDeg;
  }
  static double FindDiff(int hour, int minute)
  {
    double hourDegrees = HoursDegrees(hour, minute);
    int minuteDegrees = MinutesDegrees(minute);
    double difference = hourDegrees - minuteDegrees;

    if (difference < 0)
    {
      difference = difference * -1;
    }
    if (difference > 180)
    {
      difference = difference - 360;
      difference = difference * -1;
    }
    return difference;
  }
}
