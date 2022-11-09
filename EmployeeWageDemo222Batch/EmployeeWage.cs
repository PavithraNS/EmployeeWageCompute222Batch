
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo222Batch
{
    class EmployeeWage
    {
        static void Main(string[] args)
        {
            //master
            Console.WriteLine("Welcome to EmployeeWage Computation");
            //UC1 
            const int EMP_RATE_PER_HR = 20;
            int employeePresent = 1;
            int empWage = 0;
            int empHrs = 0;

            Random r = new Random();
            int employeeInput = r.Next(0, 2);
            if (employeePresent == employeeInput)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            //UC2
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Daily Employee Wage is:"+empWage);
            Console.ReadLine();
        }
    }
}
