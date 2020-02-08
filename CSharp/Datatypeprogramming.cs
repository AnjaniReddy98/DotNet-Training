using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypeprogramming_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;
            short s = 99;
            int n = 98;
            long l = 5678567856789;
            float f = 1.69f;
            double d = 30.99;
            decimal m = 999.99m;
            Console.WriteLine("Values of b={0}, s={1}, n={2}, l={3}, f={4}, d={5}, m={6}", b, s, n, l, f, d, m);
            DateTime dd = DateTime.Now;
            Console.WriteLine("The current date is: {0}", dd);
            Console.WriteLine("The current short date is: {0}", dd.ToShortDateString());
            Console.WriteLine("The current long date is: {0}", dd.ToLongDateString());
            Console.WriteLine("The current time is: {0}", dd.ToShortTimeString());
            Console.WriteLine("The current longtime is: {0}", dd.ToLongTimeString());
            Console.ReadKey();
        }
        int e, f;
        e = 30; f = 50;
         Add(e,f);
        double result = Multiply(e, f);
        Console.WriteLine("The product of {0} and {1} = {2}", e, f, result);
        }
            public static void Add(int e, int f)
        {
            double d = e + f;
            Console.WriteLine("The sum of {0} and {1} = {2}", e, f, d);
        }
        public static double Multiply(int e, int f)
        {
            double d = e * f;
            return d;
        }

     }
}
