using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem statement");
            EmployeeWage HCL = new EmployeeWage("HCL",20,22,90);
            HCL.EmpWage();
            EmployeeWage JIO = new EmployeeWage("JIO",25,20,100);
            JIO.EmpWage();
        }
    }
}
