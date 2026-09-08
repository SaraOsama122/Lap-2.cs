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
            int[] num = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number " + (i + 1) + ": ");
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if(num[i] % 2 == 0){
                    Console.WriteLine(num[i] + " is even");
                }else{
                    Console.WriteLine(num[i] + " is Odd");
                }
            }
        }
    }
}

