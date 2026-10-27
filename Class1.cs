using System;

namespace CalculatorApplication

{

    class Number

    {

        public int getValues(out int x, out int y, out int z)

        {

            Console.WriteLine("Enter the first value: ");

            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");

            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the THIRD value: ");

            z = Convert.ToInt32(Console.ReadLine());

           int  sum = x + y + z;

            return sum;

        }

    }

    class Class1

    {

        static void Main(string[] args)

        {
            Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            Console.WriteLine("ENROLLMENT NO:24SOECE11050");


            Number n = new Number();

            /* local variable definition */

            int a, b, c, sum;



            /* calling a function to get the values */

            sum = n.getValues(out a, out b, out c);
            Console.WriteLine();


            Console.WriteLine("After method call, value of a : {0}", a);

            Console.WriteLine("After method call, value of b : {0}", b);

            Console.WriteLine("After method call, value of c : {0}", c);

            Console.WriteLine("Sum : {0}", sum );
            Console.ReadLine();



        }

    }

}