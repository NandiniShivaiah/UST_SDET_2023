using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class Student
    {

        private string? studentname;
        private int grades1, grades2, grades3, grades4,grades5;

        public Student(string? studentname, int grades1, int grades2, int grades3 )
        {
            this.studentname = studentname;
            this.grades1 = grades1;
            this.grades2 = grades2;
            this.grades3 = grades3;
            
        }

        public double CalculateAverage()
        {
            double average = (grades1 + grades2 + grades3 ) / 3;
            return average;
        }
    }

}
