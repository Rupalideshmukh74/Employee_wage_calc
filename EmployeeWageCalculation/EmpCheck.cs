using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    class EmpCheck
    {
        
        public void AtendanceCheck(int empPresent)
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
       
       public void CalculateDailyWage(int emPresent)
        {
            //int FullTime = 8;
          //  int PartTime = 4;
            int WagePerHour = 20;
            int WorkHours = 0;
            switch(emPresent)
            {
                case 1:
                    Console.WriteLine("Employee  present part time ");
                    WorkHours = 4;
                    break;
                case 2:
                    Console.WriteLine("Employee  present full time ");
                    WorkHours = 8;
                    break;
                default:
                    Console.WriteLine("Employee absent ");
                    break;
                    

            }
            Console.WriteLine("Calculating Emp Wage");
            int DailyPartWage = WagePerHour * WorkHours;
            Console.WriteLine(" DailyPartWage : " + DailyPartWage);

        }
    }  

}
