using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceprogram
{
    class Program
    {
        static void Main(string[] args)      //entry point of CSharp console application
        {
            Student stu = new Student();
            var TotalMarks = stu.GetTotalMarks(70, 80);
            Console.WriteLine("TotalMarks: {0}", TotalMarks);

            TotalMarks = stu.GetTotalMarks(70, 80, 50);
            Console.WriteLine("TotalMarks after adding sub3 {0}",TotalMarks);

            College objC = new College();
            var tm = objC.GetAddScore(20);
            Console.WriteLine("Addscore is {0}", tm);

            Console.ReadKey();
        }
    }
    public class Student
    {
        public double GetTotalMarks(int sub1, int sub2)  //This method is overloaded with deffrent signatures
        {
            double TotalMarks = sub1 + sub2;
            return TotalMarks;
        }
        public double GetTotalMarks(int sub1, int sub2, int sub3)  //GetSalary method is overloaded
        {
            double TotalMarks = (sub1 + sub2) + sub3;
            return TotalMarks;
        }

        //this method will be overidden in some other derived class
        public virtual double GetAddScore(int TotalMarks, int AddScore)
        {
            double tm = TotalMarks + AddScore;
            return tm;

        }

    }
    public class College : Student

    {
        public override double GetAddScore(int TotalMarks, int AddScore)  //signature remains same while overriding
        {
            return base.GetAddScore(TotalMarks, AddScore);          //'base' refers to the base class

           double tm = AddScore + TotalMarks;
           return tm;
        }
    }
}
