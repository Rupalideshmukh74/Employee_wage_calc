using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    class EmpCheck
    {
        
       /* public void AtendanceCheck(int empPresent)
        {
            if (empPresent == 1)
            {
                Console.WriteLine(" Employee present. \n");
            }
            else
            {
                Console.WriteLine(" Employee absent. \n");
            }

        }
       */
       public void CalculateDailyWage()
        {
            //int FullTime = 8;
            int PartTime = 4;
            int WagePerHour = 20;
            int DailyPartWage = PartTime * WagePerHour;
            Console.WriteLine(" DailyPartWage : " + DailyPartWage);

        }
    }  

}
