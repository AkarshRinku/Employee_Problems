using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage1
{
    class UC_5CalculatingWagesForMonth
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 20;
        public static void Wages_for_month()
        { //varables
            int empHrs = 0, empWage = 0, TotalEmpWage = 0;
            //Computaion
            for (int day = 0; day < Num_Of_Working_Days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * Emp_Rate_Per_Hour;
                TotalEmpWage += empWage;
                Console.WriteLine("Emp Wage of day : " + (day + 1) + " is : " + empWage);
                Console.WriteLine("Total Emp Wage : " + TotalEmpWage);
            }
        }
    }
}
    

