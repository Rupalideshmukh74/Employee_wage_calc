﻿using System;
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

    }  
}