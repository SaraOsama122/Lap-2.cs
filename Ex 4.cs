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
            string[] names = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter name " + (i + 1) + ": ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNames in Uppercase:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(names[i].ToUpper());
            }
        }
    }
}

