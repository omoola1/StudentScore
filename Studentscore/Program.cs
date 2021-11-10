using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int value;
            string name;

            string textfilepath = @"C:\Users\support\source\repos\StudentScore\Studentscore\bin\Debug\New folder\StudentScore.txt";
            string textfilepathb = @"C:\Users\support\source\repos\StudentScore\Studentscore\bin\Debug\New folder\UpgradeStudentScore.txt";

            foreach (string line in File.ReadAllLines(textfilepath))

            {
                value = Convert.ToInt32(line.Substring(line.Length - 2));
                if (value <= 50)
                {
                    value += 10;

                }
                else
                {
                    value += 5;
                }
                name = line.Substring(0, line.Length - 2);
                name += value;

                string[] myArray = {name};
                File.AppendAllLines(textfilepathb, myArray);

               // Console.WriteLine("Hello World");
               // Console.ReadLine();
            }
        }
    }
}
