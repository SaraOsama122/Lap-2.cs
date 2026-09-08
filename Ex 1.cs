using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace HelloWorld
{
    public class Program
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n1- Add");
            Console.WriteLine("2- Subtract");
            Console.WriteLine("3- Multiply");
            Console.WriteLine("4- Divide\n");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    break;
                case 4:
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine("Result = " + result);
        }
    }
}
