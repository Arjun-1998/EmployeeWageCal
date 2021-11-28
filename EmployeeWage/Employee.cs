using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Employee
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        //variable
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;

        public void Attendance()
        {
            Random rand = new Random();
            int rem = rand.Next() % 2;
            if (rem > 0)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }

        }
        
       
            public double DailyWage()
            {
                Random random = new Random();
                //Computation
                int empCheck = random.Next(0, 2);
                if (empCheck == IS_FULL_TIME)
                {
                    empHrs = 8;
                }
                else
                {
                    empHrs = 0;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Emp Wage : " + empWage);
                return empWage;

            }
        public void PartTime()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
        public void CaseStatement()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case 0:
                    empHrs = 4;
                    break;
                case 1:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
        public void MonthWages()
        {
            Random random = new Random();
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                int empcheck = random.Next(0, 3);
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
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
    }

