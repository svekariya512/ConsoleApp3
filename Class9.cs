using System;

namespace Concept_demo
{
    // Abstract base class
    abstract class abstrat1
    {
        public abstract void Display();
    }
    interface IA
    {
        void Test1();
    }
    interface IB
    {
        void Test1();
        void Test2();
        void Test3();

    }
    interface IC : IA, IB
    {
        void Test4();
        void Test5();
    }
    class Employee : IC
    {
        public void Test1() { }
        public void Test2() { }
        public void Test3() { }
        public void Test4() { }
        public void Test5() { }

    }

    //interface 
    //what a class must do but not how it does
    //it can not add data members, concrete methods
    // all the methods are implicitly abstract & public
    //a class must implement all the methods of interface being implement

    interface ITest
    {
        void Testing(); //  abstract;
    }



    // Derived class 1
    class Employee1 : abstrat1, ITest
    {
        public void Testing()
        //public void Testing()
        {

        }
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

//interface 
//what a class must do but not how it does