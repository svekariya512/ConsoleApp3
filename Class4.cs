using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class4
    {
        static int MatSearch(int[,] mat, int n, int m, int x)
        {
            int row = 0;
            int col = m - 1;

            while (row < n && col >= 0)
            {
                if (mat[row, col] == x)

                    return 1;

                else if (mat[row, col] > x)

                    col--;

                else

                    row++;
            }
                
                return 0;
            }
                static void Main(string[] args)
                {
            Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            Console.WriteLine("ENROLLMENT NO:24SOECE11050");

            int[,] mat =
                    {
                        { 3, 30, 38},
                        { 44, 52, 54},
                        { 57, 60, 69 }
                                    };
                   int result = MatSearch(mat, 3, 3, 50);
                  
                        Console.WriteLine(result);
              
                        Console.ReadLine();
                    }
                }
            }
        
    
