using Case_study.CustomExcep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Case_study.CustomExcep.EnrollmentException;


namespace Case_study
{
    internal class Course:IEnrollable
    {
        public int CourseCode { get; set; }
        public string? Title { get; set; }
        public string? Instructor { get; set; }
        public int? SeatsAvailable { get; set; }
        public object? EnrollmentException { get; private set; }

        public static List<Course> courses = new List<Course>();
        public List<Student> Enrollments = new List<Student>();

        public void CourseRegistration(int courseId, int studId)
        {
            var cour = courses.Find(x => x.CourseCode == courseId && x.SeatsAvailable >= x.Enrollments.Count);
            var name = Student.students.Find(x => x.StudentId == studId);
            var stud = cour.Enrollments.Find(x => x.StudentId == studId);

            if (cour == null)
            {
                throw new FullException(EnrollmentException.exceptionMessages["One"]);
            }
            else if (stud != null)
            {
                throw new DuplicateException(EnrollmentException.exceptionMessages["Two"]);
            }
            else
            {
                cour.Enrollments.Add(name);
                Console.WriteLine("Successfully Registered!!!");
            }

        }

        public void Withdrawal(int cId)
        {
            var data = courses.Find(x => x.CourseCode == cId);
            var removeEnroll = data.Enrollments.RemoveAll(x => x.StudentId == cId);
            if (removeEnroll != null)
            {
                Console.WriteLine("Withdrawn");
            }
            else
            {
                Console.WriteLine("Withdraw unsuccess");
            }
        }

    }

}
