using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class8
    {
        //abstract
        //highlight the feature only
        //abstract keyword used to abstract method and abstract class
        //abstract can not create object class
        //within the abstract class, you can put data member and method
        //non abstract class can create object class
        //non abstract class can not contain abstract method , constructor
        //abstract method can only be declared in abstract class
        //abstract method can not have body
        //abstract method must be override in derived class
        //abstract method can not be static, private, virtual, sealed, extern, or override
        //abstract class can contain constructor and destructor
        //abstract class can contain static constructor and static destructor
        //abstract class can contain static members
        //abstract class can contain non-static members
        //abstract class can contain properties, indexers, events, and operators
        //abstract class can contain nested types
        //abstract class can implement interfaces
        //abstract class can inherit from another abstract class or a non-abstract class
        //you can use abstract class as a partent class and derived class can inherit from it




        // Abstract base class
        abstract class abstrat1
        {
            public abstract void Display();
        }

        // Derived class 1
        class Employee1 : abstrat1
        {
            public override void Display()
            {
                Console.WriteLine("Employee1");
            }
        }

        // Derived class 2
        class Employee2 : abstrat1
        {
            public override void Display()
            {
                Console.WriteLine("Employee2");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                abstrat1 emp1 = new Employee1();
                emp1.Display();

                abstrat1 emp2 = new Employee2();
                emp2.Display();

                Console.ReadLine();
            }
        }
    }
}