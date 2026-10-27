using System;

namespace ConsoleApp3
{
    internal class Class3

    {

        static void Main(string[] args)

        {
            Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            Console.WriteLine("ENROLLMENT NO:24SOECE11050");


            Console.WriteLine("Hello, World!");

            Console.WriteLine("You entered the following {0} command line arguments:",

               args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

        }

    }
}