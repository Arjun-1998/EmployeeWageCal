using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Employee
    {
        int totalempHrs = 0;
        int TOTAL_HOUR = 100;
        int totalWorkingDays = 0;
        int TOTAL_DAYS = 20;
        int maxHourPrMonth = 0;
        int numofWorkingDays = 0;
        int WAGE_PR_HR = 20;
        int FULL_DAY_HOUR = 8;
        int HALF_DAY_HOUR = 4;
        int PRESENT = 1, HALF_DAY = 2;
        int totalsalary = 0;
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_MONTH = 10;
        //variable
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;
        int MAX_WORKING_HRS = 0;
        int FULL_WORKING_HRS = 0;
        int PART_WORKING_HRS = 0;

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
        public void MonthlyWages()
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
        public void Calculate()
        {
            Random random = new Random();
            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
                for (int j = 0; j < NUM_OF_WORKING_DAYS && empHrs < MAX_WORKING_HRS; i++)
                {
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_FULL_TIME:
                            this.empHrs = FULL_WORKING_HRS;
                            this.empHrs += FULL_WORKING_HRS;
                            break;
                        case IS_PART_TIME:
                            this.empHrs = PART_WORKING_HRS;
                            this.empHrs += PART_WORKING_HRS;
                            break;
                        default:
                            this.empHrs = 0;
                            this.empHrs += 0;
                            break;
                    }
                }
        }
        public void compute()
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            int MAX_HRS_IN_MONTH = 0;
            //computation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);

        }
        public void MultipleCompany()

        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            while (totalempHrs <= TOTAL_HOUR && totalWorkingDays <= TOTAL_DAYS)
                while (totalempHrs <= maxHourPrMonth && totalWorkingDays <= numofWorkingDays)
                {
                    totalWorkingDays++;
                    int totalSalary = WAGE_PR_HR * totalempHrs;
                    Console.WriteLine("Here is the Monthly Wage of Emp." + this.totalsalary);


                }
        }
    }       
}

