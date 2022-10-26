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
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = FULL_DAY_HR;
                Console.WriteLine("Employee is present for full Day");
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = HALF_DAY_HR;
                Console.WriteLine("Employee is present for Half Day");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            dailyEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Daily Employee Wage is: "  + dailyEmpWage);
        }
    }
}
