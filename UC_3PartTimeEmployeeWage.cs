using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage1
{
    class UC_3PartTimeEmployeeWage
    {
        public static void PartTimeWage()
        {
            // Constants
            int Is_Part_Time = 1;
            int Is_Full_Time = 2;
            int Emp_Rate_Per_Hour = 20;
            // Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            // Computation
            int empCheck = random.Next(0, 3);
            if (empCheck == Is_Part_Time)
            {
                empHrs = 4;
                Console.WriteLine("PartTime");
            }
            else if (empCheck == Is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;

            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}

