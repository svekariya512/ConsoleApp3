using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class collction_list
    {
        public static void Main(String[] args)
        {
            //creating an object of collection
            ArrayList obj = new ArrayList();
            //CollectionBase of class
            //AddingNewEventArgs a element into the collection

            obj.Add("RKU");
            obj.Add(110);
            obj.Add(125.85);
            obj.Add('X');
            obj.Add(true);
            //fetching the elements from the collection

            Console.WriteLine("Number of Elements  :" + obj.Count);
        }
    }
}
