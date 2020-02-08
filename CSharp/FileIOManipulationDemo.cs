using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOManipulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo("C:\\SampleDirectory");
            //dir.Create();

            //FileInfo file = new FileInfo(@"C:\SampleDirectory\sample.txt");
            //file.Create();
            //Console.WriteLine("The directory and the text file have been created successfully");


            FileStream fs = new FileStream(@"C:\SampleDirectory\sample.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This text has been written to the file using file input/output manipulation");

            sw.Close();
            fs.Close();

            Console.WriteLine("Some content is written to the File");

            fs = new FileStream(@"C:\SampleDirectory\sample.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            var content = sr.ReadToEnd();
            Console.WriteLine("The file content: {0}", content);

            string lineByline;
            while ((lineByline = sr.ReadLine()) != null)
            { 
                Console.WriteLine("\nThe file content: {0}", lineByline);
            }
            sr.Close();
            fs.Close();
            

            Console.ReadKey();
        }
    }
}
