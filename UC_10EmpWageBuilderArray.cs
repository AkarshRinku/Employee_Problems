using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage1
{
    public class EmpWageBuilderArray
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;

        public int num_of_company = 0;
        private CompanyEmpWage[] CompanyEmpWageArray;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpWageBuilderArray"/> class.
        /// </summary>
        public EmpWageBuilderArray()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int Emp_Rate_Per_Hour, int Num_Of_Working_Days, int Max_Hrs_In_Month)
        {
            CompanyEmpWageArray[this.num_of_company] = new CompanyEmpWage(company, Emp_Rate_Per_Hour, Num_Of_Working_Days, Max_Hrs_In_Month);
            num_of_company++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < num_of_company; i++)
            {
                CompanyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].toString());
            }
        }
        private int ComputeEmpWage(CompanyEmpWage CompanyEmpWage)
        {
            //varables
            int empHrs = 0, TotalEmpHrs = 0, TotalWorkingDays = 0;
            //Computaion
            while (TotalEmpHrs <= CompanyEmpWage.Max_Hrs_In_Month && TotalWorkingDays < CompanyEmpWage.Num_Of_Working_Days)
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
            return TotalEmpHrs * CompanyEmpWage.Emp_Rate_Per_Hour;

        }

    }
}




    

