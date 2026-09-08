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
            Console.Write("Enter your Email : ");
            string email= Console.ReadLine();

            if(email.EndsWith("@gmail.com")){
               Console.Write("Valid Gmail");
            }else{
               Console.WriteLine("Invalid Gmail");
            }

        }
    }
}

