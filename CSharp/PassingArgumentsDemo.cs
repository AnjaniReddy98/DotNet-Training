using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArgumentsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing and Unboxing
            object obj = 100;   //object is reference type
            int a = 100;
            obj = a; // converting a value type to reference implicitly - boxing
            int b = (int)a; //unboxing-converting a boxed type into a value type by explitly casting it
            Console.WriteLine("Values of a and b = {0} and {1}", a, b);
           
            //passing arguments by value type
            int i, j;
            i = 10; j = 20;
            // double sum = ShowData(i, j);
            Console.WriteLine("values of i and j before function call = {0},{1}", i, j);
            ShowData1(i, j);
            Console.WriteLine("Values of i and j before function call = {0},{1}", i, j);

            //passing argments by reference
            int k, l;
            k = 10; l = 20;
            Console.WriteLine("Values of i and j after function call = {0},{1}", k, l);
            ShowData2(ref k, ref l);
            Console.WriteLine("Values of i and j after function call = {0},{1}", k, l);
            Console.ReadLine();
        }
            public static void ShowData1(int a, int b)
            {
                Double sum = a + b;
            Console.WriteLine("sum = {0}", sum);
                a += 5;
                b += 5;
            
            }
            public static void ShowData2(ref int a, ref int b)
            {
            Double sum = a + b;
            Console.WriteLine("sum = {0}", sum);
            a += 5;
            b += 5;

            }


    }
}

