using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage calculation program!");
            Random random = new Random();
            int empPresent = random.Next(0, 2);

            EmpCheck ec = new EmpCheck();
            ec.CalculateDailyWage(empPresent);


        }
    }
}
