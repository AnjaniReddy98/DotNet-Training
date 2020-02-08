using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsDemo
{
    class Program
    {
        public delegate double SalDelegate(int ds, float sd);
        public delegate void MathDelegate(float n1, float n2);
        public delegate void printhandler();
        public event printhandler Print;
        public void Onprint()
        {
            Console.WriteLine("printing is done!");
        }
        public void show()
        {
            Console.WriteLine("inside show method");
            Print();
        }
            


       

        static void Main(string[] args)
        {
            SalDelegate deleg = new SalDelegate(GetSalary);
            var salary = deleg.Invoke(30, 800);
            Console.WriteLine("salary = {0}", salary);
            deleg += GetIncentives;    //referencing more than one method
            var incent = deleg.Invoke(30, 800);
            Console.WriteLine("Incentives = {0}", incent);

            //multicaste delegate
            MathDelegate mathdeleg = new MathDelegate(Add);

            mathdeleg += Subtract;
            mathdeleg += Multiply;
            mathdeleg += Divide;


            mathdeleg.Invoke(950, 95);

            Program objP = new Program();
            objP.Print = new printhandler(objP.Onprint);   //Registering on print event handler with print event
            objP.show();     //raise the print event(defined inside the show method)

            Console.ReadKey();
        }
        public static double GetSalary(int nds, float spd)
        {
            var salary = (nds * spd);
            return salary;
        }
        public static double GetIncentives(int nds, float spd)
        {
            var incent = 0.1 * (nds * spd);
            return incent;
        }

        public static void Add(float n1, float n2)
        {
            Console.WriteLine("\n The sum of {0} and {1} = {2}", n1, n2, n1 + n2);
        }

        public static void Subtract(float n1, float n2)
        {
            Console.WriteLine("The defference of {0} and {1} = {2}", n1, n2, n1 - n2);
        }

        public static void Multiply(float n1, float n2)
        {
            Console.WriteLine("The product of {0} and {1} = {2}", n1, n2, n1 * n2);
        }

        public static void Divide(float n1, float n2)
        {
            Console.WriteLine("The quotient of {0} and {1} = {2}", n1, n2, n1 % n2);
        }

    }


}



