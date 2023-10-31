using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Employe
    {
        public Employe(int employeId, string? employeName, int performanceRating)
        {
            EmployeId = employeId;
            EmployeName = employeName;
            PerformanceRating = performanceRating;
        }

        public int EmployeId { get; set; }
        public string? EmployeName { get; set; }
        public int PerformanceRating { get; set; }



        public static double BonusCalculation(Employe employee)
        {
            double bonusCalculation;

            if (employee.PerformanceRating > 1 &&
                employee.PerformanceRating <= 2)
            {
                bonusCalculation =
                    employee.PerformanceRating * 100000;
            }
            else if (employee.PerformanceRating > 2
                && employee.PerformanceRating <= 4)
            {
                bonusCalculation =
                    employee.PerformanceRating * 200000;
            }
            else
            {
                bonusCalculation =
                    employee.PerformanceRating * 300000;
            }

            return bonusCalculation;
        }
    }
}

