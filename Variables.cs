﻿using System;

namespace Variables
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name ?");
            Console.Write("Type your first name : ");

            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Type your last name: ");

            myLastName = Console.ReadLine();
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
        }
    }
}
