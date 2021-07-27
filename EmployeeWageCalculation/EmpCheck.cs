using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCalculation
{
    class EmpCheck
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NO_OF_WORKING_DAYS = 20;
        public void CalculateDailyWage()
        {
            int WorkHours = 0; int empWage = 0; int totalWage = 0;
            Console.WriteLine("daily Wage : ");
            for (int day = 0; day < NO_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empPresent = random.Next(0, 3);
                switch (empPresent)
                {
                    case IS_PART_TIME:
                        //Console.WriteLine("Employee  present part time ");
                        WorkHours = 4;
                        break;
                    case IS_FULL_TIME:
                        // Console.WriteLine("Employee  present full time ");
                        WorkHours = 8;
                        break;
                    default:
                        //Console.WriteLine("Employee absent ");
                        WorkHours = 0;
                        break;


                }
                empWage = WorkHours * EMP_RATE_PER_HR;
                totalWage += empWage;
                Console.Write( " "+ empWage);


            }
            Console.WriteLine("\n Total Emp Wage : " + totalWage);
        }

    }
}