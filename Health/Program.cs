using System;

namespace Health
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your Body temperature");
            double bodyTemp;
            string input;

            do
            {
                Console.WriteLine($"{name}, you made a mistake. Please enter your Body temperature");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out bodyTemp));

            Console.WriteLine(Output(name, bodyTemp));


        }

        public static string Output(string name, double bodyTemp)
        {
            if (bodyTemp < 35 || bodyTemp > 37.1)
                return $"{name}, your body temperature {bodyTemp}. Please Visit a doctor";
            else if (bodyTemp >= 35 && bodyTemp <= 36.8)
                return $"{name}, your body temperature {bodyTemp}. You may pass";
            else if (bodyTemp > 36.8 && bodyTemp <= 37.1)
                return $"{name}, your body temperature {bodyTemp}. Get some rest";
            else
                return "Incorrect data";
        }
    }
}
