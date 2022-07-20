using System;
using System.Collections.Generic;
using System.Text;
namespace demo9

{
    class Employee
    {
    static void Main(string[] args)
        {
            int employeeID;
            string employeeName;
            string designation;
            float taxAmount = 0;
            double salary = 0, netSalary = 0;
            Console.Write("Enter the id of a employee:");
            employeeID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name of emplayee:");
            employeeName = Console.ReadLine();
            Console.Write("Enter designtion:");
            designation = Console.ReadLine();
            Console.Write("Enter salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            if(salary>=10000)
            {
                taxAmount = (float)(salary * 32.5 / 100);
            }
            else
            {
                taxAmount = (float)(salary * 24.8 / 100);
            }
            netSalary = salary - taxAmount;
            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Employee ID:" + employeeID);
            Console.WriteLine("Employee Name:" + employeeName);
            Console.WriteLine("Designation:" + designation);
            Console.WriteLine("Salary:{0} $" , salary);
            Console.WriteLine("Net Salary: {0:F2} $ is rounded off to: {1} $" , netSalary,(int)netSalary);
        }
    }
}