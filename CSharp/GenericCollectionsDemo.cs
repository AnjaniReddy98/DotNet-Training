using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericCollectionsDemo
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    ArrayList items = new ArrayList(100);

        //    items.Add("Hello World");
        //    items.Add(10);
        //    items.Add(DateTime.Now);
        //    items.Add(true);

        //    foreach (object obj in items)
        //        Console.WriteLine(obj.ToString());

        //    List<int> myInts = new List<int>();

        //    myInts.Add(10);
        //    myInts.Add(80);
        //    myInts.Add(90);

        //    foreach (var n in myInts)
        //        Console.WriteLine(n.ToString());

        //    List<string> employees = new List<string>() { "Anders Helsberg", "Christian Nagel", "Jeffery Richer" };

        //    foreach (var emp in employees)
        //        Console.WriteLine(emp);

        //    Dictionary<int, string> fruits = new Dictionary<int, string>();
        //    fruits.Add(1, "Apple");
        //    fruits.Add(2, "Orange");
        //    fruits.Add(3, "Banana");
        //    fruits.Add(4, "Pineapple");
        //    fruits.Add(5, "Watermelon");

        //    foreach(KeyValuePair<int, string> kv in fruits)
        //    {
        //        Console.WriteLine("Key -> {0}, Value -> {1}", kv.Key, kv.Value);
        //    }
        //    //deleting an item from the collection

        //    fruits.Remove(4);
        //    fruits.Add(4, "Grapes");

        //    foreach (KeyValuePair<int, string> kv in fruits)
        //    {
        //        Console.WriteLine("Key -> {0}, Value -> {1}", kv.Key, kv.Value);
        //    }

        //    SortedDictionary<int, string> gadgets = new SortedDictionary<int, string>();
        //    gadgets.Add(3, "Thinkpad");
        //    gadgets.Add(1, "Notepad");
        //    gadgets.Add(5, "Smartphone");
        //    gadgets.Add(4, "CDphone");
        //    gadgets.Add(2, "CDMicrophone");

        //    foreach (KeyValuePair<int, string> kv in gadgets)
        //    {
        //        Console.WriteLine("Key -> {0}, Value -> {1}", kv.Key, kv.Value);
        //    }

        //    Console.ReadKey();
        //}
        public class Employee
        {
            static void Main(string[] args)
            {
                ArrayList Employees = new ArrayList(100);



                Employees.Add("JEFFERY");
                Employees.Add(20);
                Employees.Add("Trainee");


                foreach (object obj in Employees)
                    Console.WriteLine(obj.ToString());

                Console.ReadKey();
            }
           
            
        }

    }
}
