using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5] { 89, 90, 93, 95, 98 };
            for (int i = 0; i < marks.Length; i++)
                Console.WriteLine("Marks of C# programming = {0}", marks[i]);


            string[] employees = { "ANJANI", "RAMA", "RITHIKA", "VINEETHA" };
            for (int i = 0; i < employees.Length; i++)
                Console.WriteLine("Employee name = {0}", employees[i]);
            var avgmarks = GetAverageMarks(marks);
            Console.WriteLine("Average of marks = {0}", avgmarks);
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            marks[2] = 95;
            Console.WriteLine("Least marks obtained = {0}", marks.Min());
            Console.WriteLine("Highest marks obtained = {0}", marks.Max());

            Console.ReadKey();
        } 
        
        public static double GetAverageMarks(int[] marks)
        {
            int total = 0;
            double avg;
            for (int i = 0; i < marks.Length; i++)
                total = total + marks[i];
            avg = total / marks.Length;
            return avg;
        }
       
    }
}
