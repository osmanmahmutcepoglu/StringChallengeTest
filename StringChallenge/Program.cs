using System;
using System.Globalization;

namespace MainClass
{
    internal class Program
    {

        public static string StringChallenge(string str)
        {
            string[] parseArray = str.Split('-');

            DateTime startTime = Convert.ToDateTime(parseArray[0]);
            DateTime endTime = Convert.ToDateTime(parseArray[1]);

            TimeSpan differance = startTime.Subtract(endTime);

            double differanceMinutes = differance.TotalMinutes * -1;

            if (startTime > endTime)
            {
                differanceMinutes += (24 * 60);
            }

            return differanceMinutes.ToString();
        }


        static void Main(string[] args)
        {
            Console.WriteLine(StringChallenge("12:30am-12:00pm"));
        }

    }
}
