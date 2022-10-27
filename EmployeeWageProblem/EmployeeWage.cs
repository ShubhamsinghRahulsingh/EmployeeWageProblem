using System;
namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int WAGE_PER_HR = 20,FULL_DAY_HR = 8,HALF_DAY_HR = 4,IS_PRESENT = 0,IS_FULL_TIME = 1,IS_PART_TIME = 2;
        Random random = new Random();
        public void Attendance()
        {
            
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void EmpWage()
        {
            int dailyEmpWage = 0,empHrs = 0;
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = FULL_DAY_HR;
                    break;
                case IS_PART_TIME:
                    empHrs = HALF_DAY_HR;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            dailyEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Daily Employee Wage is: "  + dailyEmpWage);
        }
    }
}
