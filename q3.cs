using System;
using System.Collections.Generic;


namespace תרגיל_יחידה
{
    public static class q3
    {
        public static void userNumbersCalculator()
        {
            List<double> userNumbers = new List<double>();
            Console.WriteLine("enter numbers, to end enter -1");
            double number = Convert.ToDouble(Console.ReadLine());
            double sum = 0;
            int nuberOfPositives = 0;
            while (number != -1)
            {
                userNumbers.Add(number);
                sum += number;
                if (number > 0)
                    nuberOfPositives++;
                number = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"number mean {sum / (double)userNumbers.Count}");
            Console.WriteLine($"number of positive number {nuberOfPositives}");
            userNumbers.Sort();
            foreach (float num in userNumbers) { Console.WriteLine(num); }
        }
    }
}
