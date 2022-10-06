using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplyeewageapp
{
    internal class employeewage
    {
        public void empwagecount()
        {//Constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs ;
            int empWage, empcheck;
            Random random = new Random();
            //Computation
            empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {

                empHrs = 8;
                Console.WriteLine("Employee is present");

            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("EmployeeWage :" + empWage);

        }
    }
}
