using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage1
{
    class UC_8AbilityToComputeEmpWageForMultipleCompany
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        /*public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 2;
        public const int Max_Hrs_In_Month = 10;*/

        public static int Emp_Wage_Multiple_Comp(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
        {
            //varables
            int empHrs = 0, TotalEmpHrs = 0, TotalWorkingDays = 0;
            //Computaion
            while (TotalEmpHrs <= Max_Hrs_In_Month && TotalWorkingDays < Num_Of_Working_Days)
            {
                TotalWorkingDays++;
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
                TotalEmpHrs += empHrs;
                Console.WriteLine("Days#: " + TotalWorkingDays + "  empWage : " + empHrs);
            }
            int TotalEmpWage = TotalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage : " + TotalEmpWage);
            return TotalEmpWage;
        }
    }
}
