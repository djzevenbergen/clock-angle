using System;
using System.Collections.Generic;

namespace Clock.Models
{
  public class Clocks
  {
    private static double HoursDegrees(int hour, int minute)
    {
      double hourDeg = ((30 * hour) + (0.5 * minute));
      return hourDeg;
    }
    private static int MinutesDegrees(int minute)
    {
      int minDeg = (minute * 6);
      return minDeg;
    }
    public static double FindDiff(int hour, int minute)
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
}
