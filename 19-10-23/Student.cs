using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1
{
    internal class Student
    {
        private string? name;
        private int[] marks = new int[3];
        private string grade;

        public Student(string? name, int[] marks, string grade)
        {
            this.Name = name;
            this.Marks = marks;
            this.Grade = grade;
        }

        public string? Name { get => name; set => name = value; }
        public int[] Marks { get => marks; set => marks = value; }
        public string Grade { get => grade; set => grade = value; }


        public double CalculateAverage()
        { double average = Marks.Average();
            return average;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine("Student Name:" + Name);
            Console.WriteLine("Grade:" + Grade);
            int i = 1;
            int total = 0;
            foreach(int mark in Marks)
            {
                Console.WriteLine("Marks{0}:{1}", i++, mark);
                total += mark;
            }

            Console.WriteLine("Total marks:" + total);
            Console.WriteLine();
        }
        public void GetMarksSummary()
        {
            int high = marks[0];
            int low = marks[0];
            foreach(int mark in Marks)
            {
                if (mark > high)
                    high = mark;
                if (mark < low) low = mark;
            }

            Console.WriteLine("Highest:" + high);
            Console.WriteLine("Lowest:" + low);
            Console.WriteLine();
        }

    }
}
