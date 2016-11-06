﻿using System;
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


            GradeBook gradeBook = new GradeBook();
            gradeBook.AddGrade(66f);
            gradeBook.AddGrade(66f);
            gradeBook.AddGrade(66f);
            gradeBook.AddGrade(66f);
            GradeStatistics stats =  gradeBook.ComputeStatistics();

            Console.WriteLine("Lowest grade is {0}",stats.LowestGrade);
            Console.WriteLine("Highest grade is {0}",stats.HighestGrade);
            Console.WriteLine("Average of grades is {0}",stats.AverageOfGrades);

            Console.ReadLine();
        }
    }
}
