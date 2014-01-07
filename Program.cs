using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquaredCalculatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables.
            String sUserResp = String.Empty;
            String sUserName = String.Empty;
            Double dNumber = 0.0;
            Double dSquared = 0.0;

            Console.WriteLine("Welcome to Squared Calculator!");
            Console.WriteLine("\nI will give you the square of any number you enter.");
            Console.Write("\nWhat is your name? ");
            sUserName = Console.ReadLine();
            Console.Write("\nHello, " + sUserName + "! Please enter the number you want squared (0.0 format): ");
            sUserResp = Console.ReadLine();
            dNumber = Convert.ToDouble(sUserResp);
            dSquared = dNumber * dNumber;
            Console.WriteLine("\nYour number squared is " + dSquared.ToString() + ". Have a great day!");
            Pause(sUserName + ", press the enter key to close this window.");

        }

        static void Pause(String sMsg)
        {
            Console.WriteLine("\n" + sMsg);
            Console.ReadLine();
        }
    }
}
