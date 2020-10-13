using System;

namespace HourAndMinuteAngle
{
    class Program
    {
        //WHITEBOARDING EXERCISE
       /* Given a daytime struct - calculate angle between hour hand and minute hand
        example:
        input: (int hr 3, int min 30)
        output: double angle 90 */


        /*Process:
        360 degrees / 12 hours = each hour is a 30 degree angle
        360 / 60 minutes = each minute is 6 a degree angle
        thus, 3:00pm = 30 * 3 */


       public static void AngleBetweenHrAndMin(int hr, int min)
        {
            int hourAngle = 30 * hr;
            int minAngle = 6 * min;

            int result = hourAngle - minAngle;

            if (result < 0)
            {
                result *= -1;
            }
            Console.WriteLine($"The angle between hour {hr} and min {min} is {result} degreers");
        }
        static void Main(string[] args)
        {
            AngleBetweenHrAndMin(3, 30);
        }
    }
}
