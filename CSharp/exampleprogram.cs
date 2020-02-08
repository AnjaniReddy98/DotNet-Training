using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int person_Age;
            string person_Name;
            Console.WriteLine("Enter person name\n");
            person_Name = Console.ReadLine();
            Console.WriteLine("Enter person age\n");
            person_Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Congratulations Mr/Miss {0} on your {1} birthday", person_Name ,person_Age);
            Console.ReadKey();
        }
    }
}
