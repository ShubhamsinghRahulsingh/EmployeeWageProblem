using System;
namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int FULL_DAY_HR = 8, HALF_DAY_HR = 4, IS_PRESENT = 0, IS_FULL_TIME = 1, IS_PART_TIME = 2;
        Random random = new Random();
        int WAGE_PER_HR,TOTAL_WORKING_DAYS,TOTAL_WORKING_HRS;
        string COMPANY;
        public EmployeeWage(string COMPANY, int WAGE_PER_HR, int TOTAL_WORKING_DAYS, int TOTAL_WORKING_HRS)
        {
            this.COMPANY = COMPANY;
            this.WAGE_PER_HR = WAGE_PER_HR;
            this.TOTAL_WORKING_DAYS = TOTAL_WORKING_DAYS;
            this.TOTAL_WORKING_HRS = TOTAL_WORKING_HRS;
        }
    
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
            int totalEmpWage = 0, empHrs = 0;
            for (int i = 0; i <TOTAL_WORKING_DAYS && empHrs< this.TOTAL_WORKING_HRS; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs +=FULL_DAY_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs +=HALF_DAY_HR;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
                
            }
            totalEmpWage = this.WAGE_PER_HR * empHrs;
            Console.WriteLine("Total monthly wage of employee for company "+COMPANY+" is "+totalEmpWage);
        }
    }
}
