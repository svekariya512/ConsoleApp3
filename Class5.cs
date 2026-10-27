using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            Console.WriteLine("ENROLLMENT NO:24SOECE11050");
            int n, sum = 0;
            Console.WriteLine("enter size of array");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter element " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }


            Console.WriteLine("sum of array elements is: " + sum);
            Console.ReadLine();
        }
    }
    }