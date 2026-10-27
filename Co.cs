using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class A
    {

        public A()
        {
            Console.WriteLine("from a");
        }



        class B : A
        {
            public B()
            {
                Console.WriteLine("from b");
            }


            class C : B
            {

                public C()
                {
                    Console.WriteLine("from c");
                }

                class D : C
                {
                    public D()
                    {
                        Console.WriteLine("from d");
                    }

                    class Program
                    {
                        public static void Main(string[] args)
                        {
                            D obj = new D();
                        }
                    }
                }
            }
        }
    }
}
                
            

