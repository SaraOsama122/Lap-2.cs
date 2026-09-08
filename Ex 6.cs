using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Largest Number = " + max);
            Console.WriteLine("Minimum Number = " + min);
        }
    }
}

