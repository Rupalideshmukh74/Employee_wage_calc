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
        public const int MAX_HOURS_MONTH = 100;
        public void CalculateDailyWage()
        {
            int WorkHours = 0, empWage = 0, empHours=0, totalWage = 0,  totalWorkingDays = 0, totalhours = 0;
            Console.WriteLine("daily Wage : ");
            while (totalhours <= MAX_HOURS_MONTH && totalWorkingDays < NO_OF_WORKING_DAYS)
            {
                totalWorkingDays++;

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
                totalhours += empHours;
                Console.WriteLine("Days# : " + totalWorkingDays + "Emp Hrs :" + empHours);
                empWage = WorkHours * EMP_RATE_PER_HR;
                totalWage += empWage;
                Console.Write( " "+ empWage);


            }
            Console.WriteLine("\n Total Emp Wage : " + totalWage);
        }

    }
}