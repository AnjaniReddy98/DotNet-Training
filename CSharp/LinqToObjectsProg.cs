using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsProg
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employees = new string[6] { "Jeffery", "Andrew", "Mathew", "Jacob", "James", "Virat" };

            //using query syntax
            var knownEmpls = from emp in employees
                             where emp.StartsWith("J")
                             select emp;
            foreach (string emp in knownEmpls)
            {
                Console.WriteLine("EmpName starts with J: {0}", emp);
            }

            //using method syntax
            //=> is known as Lambda operator, and is read as goes
            var someEmpls = employees.Where(s => s.Contains("A"));

            foreach (string emp in someEmpls)
            {
                Console.WriteLine("EmpName starts with A: {0}", emp);
            }
            Console.WriteLine("***************************");

            List<string> fruits = new List<string>()
            {
                "Apple",
                "Orange",
                "Grapes",
                "PineApple",
                "Banana",
                "Watermelon"};

            var fruitswithP = from fruit in fruits
                              where fruit.Contains("P")
                              select fruit;

            foreach (string fruit in fruitswithP)
            {
                Console.WriteLine("EmpName starts with P: {0}", fruit);
            }

            var largerNameFruits = from fruit in fruits
                                   where fruit.Length > 6
                                   select fruit;
            Console.WriteLine("***************************");

            foreach (string fruit in largerNameFruits)
            {
                Console.WriteLine("Larger name fruit: {0}", fruit);
            }
            Console.WriteLine("***************************");
            //using method syntax
            var smallerNameFruits = fruits.Where(fruit => fruit.Length <= 6);

            foreach (string fruit in smallerNameFruits)
            {
                Console.WriteLine("Smaller name fruit: {0}", fruit);
            }
            int[] marks = new int[6] { 98, 86, 89, 80, 94, 93 };
            var highMarks = from m in marks
                            where m > 90
                            select m;
            foreach (var m in highMarks)
            {
                Console.WriteLine("High Marks: {0}", m);
            }
            Console.WriteLine("***************************");


            var marksInOrder = from m in marks
                               orderby m
                               select m;

            foreach (var m in marksInOrder)
            {
                Console.WriteLine("Marks in order: {0}", m);
            }

            Console.WriteLine("***************************");

            //using method syntax
            var marksInAOrder = marks.OrderBy(m => m);
            foreach (var m in marksInAOrder)
            {
                Console.WriteLine("Marks in order: {0}", m);
            }
            Console.WriteLine("***************************");

            var marksInDOrder = marks.OrderByDescending(m => m);
            foreach (var m in marksInDOrder)
            {
                Console.WriteLine("Marks in order: {0}", m);
            }
            List<Products> Products = new List<Products>()
            {
                new Products() { ProID = 1, ProName = "Cadbury Choclate" },
                new Products() { ProID = 2, ProName = "Nestle Choclate" },
                new Products() { ProID = 3, ProName = "Britania" },
            };
            var prod = from pro in Products
                       where pro.ProName.Contains("Choclate")
                       select pro;
            foreach (var pro in prod)
            {
                Console.WriteLine("ProductID: {0},ProductName: {1}", pro.ProID, pro.ProName);
            }
            Console.WriteLine("*****************************");

            List<Teacher> Teachers = new List<Teacher>() { new Teacher { ID = 1, FirstName = "Anders", LastName = "Helsberg", City = "Redmond"},
                                                   new Teacher { ID = 2, FirstName = "Andrew", LastName = "Trolesan", City = "Lake City" },
                                                   new Teacher { ID = 3, FirstName = "Jeffery", LastName = "Richter", City = "Seattle"} };

            List<Student> Students = new List<Student>() { new Student { ID = 1, FirstName = "Christian", LastName = "Nagel", City = "Redmond"},
                                                   new Student { ID = 2, FirstName = "Dino", LastName = "Esposito", City = "Seattle" },
                                                   new Student { ID = 3, FirstName = "Mathews", LastName = "McDonald", City = "New York"}};

            var peopleInseattle = (from teacher in Teachers
                                   where teacher.City == "Seattle"
                                   select teacher.FirstName).Concat(from student in Students
                                                                    where student.City == "Seattle"
                                                                    select student.FirstName);
            foreach (var person in peopleInseattle)
            {
                Console.WriteLine("From seattle City: {0}", person);
            }
            Console.ReadLine();
        }
    }
    public class Products
    {
        public int ProID { get; set; }
        public string ProName { get; set; }
    }

    public class Teacher
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
   

