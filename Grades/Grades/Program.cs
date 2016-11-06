using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] grades = new float[] {66.0f,78.5f,89.1f,98.0f};
            float sum = 0f;
            float lowest = 100f;
            float highest = 0f;
            foreach (float grade in grades) {
                sum = sum + grade;
                if (grade < lowest)
                {
                    lowest = grade;
                }
                if (grade > highest)
                {
                    highest = grade;
                }
            }
            float average = sum / grades.Length;
            Console.WriteLine("Lowest grade is {0}",lowest);
            Console.WriteLine("Highest grade is {0}",highest);
            Console.WriteLine("Average of grades is {0}",average);

            Console.ReadLine();
        }
    }
}
