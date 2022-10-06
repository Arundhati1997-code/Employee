using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplyeewageapp
{
    internal class Wages
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        

        public static void Ctc()
        {
            //Constants

            int empHrs = 0, empWage = 0, totalempwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
                
            //Computation
            
            switch (empcheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            totalempwage += empWage;
            Console.WriteLine("EmployeeWage :" + empWage);
            Console.WriteLine("total Emp wage :" + totalempwage);
        }
        
    }
}
