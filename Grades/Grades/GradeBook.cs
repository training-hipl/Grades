using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
   public  class GradeBook
   {

        public GradeBook()
        {

            grades = new List<float>();
            grades.Add(66.0f);
            grades.Add(78.5f);
            grades.Add(82.3f);
            grades.Add(98.0f);
        }

        public void AddGrade(float grade) {
            grades.Add(grade);
        }


        public GradeStatistics ComputeStatistics() {

            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;
            float lowest = 100f;
            float highest = 0f;
            foreach (float grade in grades)
            {
                sum = sum + grade;
                lowest = Math.Min(grade, lowest); 
                highest = Math.Max(grade, highest);
            }

            stats.LowestGrade = lowest;
            stats.HighestGrade = highest;
            stats.AverageOfGrades = sum / grades.Count;

            return stats;
        }

        List<float> grades; 

   }
}
