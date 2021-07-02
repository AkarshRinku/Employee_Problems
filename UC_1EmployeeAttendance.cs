using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWage1
{
    class UC_1EmployeeAttendance
            {
                public static void EmpAttendance()
                {
                    //constants
                    int IS_FULL_TIME = 1;
                    Random random = new Random();
                    //computation
                    int empCheck = random.Next(0, 2);

                    if (empCheck == IS_FULL_TIME)

                    {
                        Console.WriteLine("Employee is Present");
                    }
                    else
                    {
                        Console.WriteLine("Employee is Absent");
                    }
                }
            }

           


}

