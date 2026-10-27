using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class7
    {
        public static void main(String[] args)
        {


            int number;
            Random r1 = new Random();
            int num = r1.Next(1, 100);

            Console.WriteLine("Random number between 1 and 100: " + num);
        }
    }
}