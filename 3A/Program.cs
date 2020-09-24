using System;
using System.Globalization;

namespace Project3A
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls the userName method
            userName();

        }

        // userName method
        private static void userName()
        {
            // asks user for their name
            Console.WriteLine("What is your name?");
            // user input stored as userName
            string userName = Console.ReadLine();
            // console prints Hello plus the user input
            Console.WriteLine("Hello " + userName);
        }
    }
}

