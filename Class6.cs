using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            Console.WriteLine("ENROLLMENT NO:24SOECE11050");
            int n, search;
            int found = 0;

            Console.WriteLine("enter number of elements  :");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("element {0} ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("enter element to search :");
            search = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == search)
                {
                    found = 1;
                    break;
                }
            }
            Console.WriteLine(found);
            Console.ReadLine();
        }
    }
}
