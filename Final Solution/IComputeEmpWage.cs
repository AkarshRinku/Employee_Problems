using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage1.Final_Solution
{
    public interface IComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth);
        void computeEmpWage();

        int getTotalWage(string company);
    }


}

