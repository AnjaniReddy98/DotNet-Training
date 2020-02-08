using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class Program
    {
        static void Main(string[] args)
        {
            //string message = greetings(35,"Jeffery");
            var message = greetings(35, "Jeffery");//var is used for implicitlyb type local variables
            Console.WriteLine(message);
            Console.ReadKey();
        }
        public static string greetings(int age, string name)
        {
            return string.Format("Congratulations Mr/Miss {0} on your {1} Birthday!", name, age);
        }
    }
}
