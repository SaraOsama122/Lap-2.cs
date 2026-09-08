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
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Original name : " + name);
            Console.WriteLine ("Uppercase :" +name.ToUpper());
            Console.WriteLine ("Lowercase :" +name.ToLower());
            Console.WriteLine("Length: " + name.Length);
            Console.WriteLine("Trimmed Name: " + name.Trim());
        }
    }
}

