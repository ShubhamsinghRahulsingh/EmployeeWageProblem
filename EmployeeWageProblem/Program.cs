using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem statement");
            EmployeeWage employee1 = new EmployeeWage();
            int Wage1=employee1.EmpWage(80,20,100);
            Console.WriteLine("Employee1 Monthly Wage is: " +Wage1);
            EmployeeWage employee2 = new EmployeeWage();
            int Wage2 = employee1.EmpWage(70, 25, 90);
            Console.WriteLine("Employee2 Monthly Wage is: " + Wage2);
        }
    }
}
