﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_App
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Calculator Application");

            string number = Console.ReadLine();
            decimal first = Convert.ToDecimal(number);

            string number1 = Console.ReadLine();
            decimal second = Convert.ToDecimal(number1);
      
            Console.WriteLine("What Operation");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                   
                    Console.WriteLine(first+second);
                    break;
                case "-":
                    Console.WriteLine(first - second);
                    break;
                case "/":
                    Console.WriteLine(first / second);
                    break;
                case "*":
                    Console.WriteLine(first * second);
                    break; 

            }
            Console.ReadLine();
        }
    }
}
