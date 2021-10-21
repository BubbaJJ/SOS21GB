using System;
using System.Collections.Generic;

namespace Vecka2.ForEach
{
    static class Exercise13
    {
        public static void Solution()
        {
            void WithInts()
            {
                List<int> numbers = new List<int>(10);
                int input;
                int sum = 0;
                double avg;

                for (int i = 0; i < numbers.Capacity; i++)
                {
                    Console.Write("Enter number for index {0}: ", i);
                    input = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(input);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }

                // För att kunna få svaret som double behöver vi casta(konvertera) vår int till en double.
                avg = (double)sum / numbers.Count; 

                Console.WriteLine("Total sum: {0}", sum);
                Console.WriteLine("Average: {0}", avg);
            }

            void WithDoublesV1()
            {
                List<double> numbers = new List<double>(10);
                double input;
                double sum = 0;
                double avg;

                for (int i = 0; i < numbers.Capacity; i++)
                {
                    Console.Write("Enter number for index {0}: ", i);
                    input = Convert.ToDouble(Console.ReadLine());
                    numbers.Add(input);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }

                avg = sum / numbers.Count;

                Console.WriteLine("Total sum: {0}", sum);
                Console.WriteLine("Average: {0}", avg);
            }

            void WithDoublesV2()
            {
                List<double> numbers = new List<double>(10);
                double input;
                double sum = 0;
                double avg;

                for (int i = 0; i < numbers.Capacity; i++)
                {
                    Console.Write("Enter number for index {0}: ", i);
                    input = Convert.ToDouble(Console.ReadLine());
                    numbers.Add(input);
                    sum += input;
                }

                avg = sum / numbers.Count;

                Console.WriteLine("Total sum: {0}", sum);
                Console.WriteLine("Average: {0}", avg);
            }

            WithInts();
            WithDoublesV1();
            WithDoublesV2();
            
        }
    }
}
