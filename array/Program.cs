using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Arrays
{
    class Program
    {
        static int column;
        static int row;

        static void Main(string[] args)

        {

            Begin();
        }


        public static void Begin()
        {
            Console.WriteLine("Welcome to the program for addition of arrays");
            ArrDimension();

            Console.WriteLine("Enter the first Array");
            int[,] a = ArrayCreate();
            Console.WriteLine("Enter the second Array");
            int[,] b = ArrayCreate();
            Console.WriteLine("Look at the result");
            Result(a,b);

            Console.ReadKey();
        }

        public static int[,] ArrDimension()
        { 
           Console.WriteLine("How many columns?");
           column = int.Parse(Console.ReadLine());
           Console.WriteLine("How many rows?");
           row = int.Parse(Console.ReadLine());
           int [,] Arr1 = new int [column, row];

           return Arr1 ;
        }

        public static int[,] ArrayCreate()
        {
            int[,] Arr1 = new int[column, row];
            for (int i = 0; i < column; i++)
                for (int k = 0; k < row; k++)
                {
                    Console.Write("[" + i + "," + k + "]=");
                    Arr1[i, k] = int.Parse(Console.ReadLine());
                }
            return Arr1;
        }


        public static void Result(int[,] a, int[,] b)
        {

            for (int i = 0; i < column; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    Console.Write("{0}\t", a[i, k]+ b[i,k]);
                }
                Console.WriteLine();
            }
        }
        
    }
    
}