using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            Console.WriteLine("ENROLLMENT NO:24SOECE11050");
            int[] arr = { 1, 2, 3, 2, 1, 4 };

            Console.WriteLine("number occuring once:");

            for (int i = 0; i < arr.Length; i++)
            {

                int count = 0;


                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {

                    Console.WriteLine(arr[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}