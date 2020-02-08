using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePracticeProgram
{
    delegate int MathOperation(int n);
    class Program
    {
        static int num = 950;
        public static int AddNum(int a)
        {
            num += a;
            return num;
        }

        public static int SubNum(int b)
        {
            num -= b;
            return num;
        }

        public static int DivNum(int c)
        {
            num %= c;
            return num;
        }

        public static int MultNum(int d)
        {
            num *= d;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            MathOperation n1 = new MathOperation(AddNum);
            MathOperation n2 = new MathOperation(SubNum);
            MathOperation n3 = new MathOperation(DivNum);
            MathOperation n4 = new MathOperation(MultNum);
            n1(95);
            Console.WriteLine("The sum of {0} and {1} = {2}", num,n1,getNum());
            Console.WriteLine("The difference of {0} and {1} = {2}",num,n1,getNum());
            Console.WriteLine("The quotient of {0} and {1} = {2}",num,n1,getNum());
            Console.WriteLine("The product of {0} and {1} = {2}",num,n1,getNum());
            Console.ReadKey();
        }
    }
}
