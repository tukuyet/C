/*
*produc.cs
/*Copyright Nguyen Anh Tuan . All rights resever
*/
using System;
using System.Collections.Gereric;
using System.Text;

namespace Company
{
    ///<summary>
    ///
    ///The program demonstrates the use of decision-making statemens.
    ///class Employee accepts,validates,calculates and displays the details of the Emloyee
    ///using if ,if-else and switch-case statements.
    ///</summary>
    class Employee
    {
        ///<summary>
        ///The entry point for the applicasion.
        ///</summary>
        /// <paran name="args"> A list of comand line aryuments<paran>
        
         static void Main(string[] args)
         {
            //Integer variable to store the employee ID
            int employeeID;
            
            //String variable to store the employee name and designation
            string employeeName;
            string designation="";

            //DateTime variable to store the employee date of birth
            DateTime birthDate;

            //Character variable to store the employee gender
            char gender;

            //Byte variable to store the number of years served
            byte yearsServed;

            //Double variable to store bonus,salary,tax amount ,and net salary
            double bonus=0,salary=0,taxAmount=0,netSalary=0;

            //Accepting the details of the employee and validating it using if statement
            Console.Write("Enter the ID of employee :");
            if (employeeID >0)
            {
                Console.Write("Enter the name of employee:");
                employeeName = Console.Readline();
                if (employeeName !="" && employeeName.Length<48)
                {
                    Console.Write("Enter date of birth [MM/DD/YYY]: ");
                    birthDate = convert.ToDateTime(Console.ReadLine());
                    int age =(DateTime.Today.Subtract(birthDate)).Days/365;
                    if (age >=18)
                    {
                       Console.Write("Enter gender [H/F]":);
                       gender= convert.ToChar(Console.ReadLine())

                       Console.WriteLine("Select designation (choose  the number):");
                       Console.WriteLine("1. Manager \n2. System Analyst \n3 Devellaper \n4. Accountant");
                       Console.WriteLine("Enter your choice:");
                       int choice = Conver.ToInt32(Console.ReadLine());

                       Console.Write("Enter the tenure int year :");
                       yearsServed =Conver.ToByte(Console.ReadLine());

                       //Assigning salary based on the designation selected using switch statement
                       switch (choice)
                       {
                        case 1:
                            designation = "Manage";
                            salary =21346;
                            break;
                        case 2:
                            designation = "System Analyst";
                            salary =16729;
                            break;
                        case 3:
                            designation = "Developer";
                            salary =14525;
                            break;
                        case 4:
                            designation = "Accountant";
                            salary =13215;
                            break;
                        
             
                       }
                       //Calculating banus based on the number of year seved
                       if (years >=3)
                       {
                        if (salary>2000)
                        {
                            bonus = salary *0.09;
                        }
                        else if (salary > 1400 && salary <= 2000)
                        {
                            bonus = salary*0.05;
                        }
                        else
                        {
                         bonus=salary*0.02;
                        }
                    //Calculating tax amount ang net salary
                    taxAmount = salary * 33 / 100;
                    netSalary = salary- taxAmount;

                    //Displaying the details of employee Console.WriteLine("\Employee Details:");
                    Console.WriteLine("Employee:" + employeeID );
                    Console.WriteLine("Employee:" + employeeName);
                    Console.WriteLine("Date of Birth:" + birthDate );
                    if{gender == 'M'}
                    Console.WriteLine("Gender :Male");
                    else
                    Console.WriteLine("Gender :Female");
                    Console.WriteLine("Designation:" +designation);
                    Console.WriteLine("Tenure:" +yearsServed);
                    Console.WriteLine("Salary:{0} S", salary);
                    Console.WriteLine(":Tax Amount :{0} $",taxAmount);
                    Console.WriteLine("Net Salary: {0:F2} $ is rounded off to : {1} $",netSalary,(int)netSalary);
        
                    Console.WriteLine("Bonus:{0} $",bonus);

                        
                }
                else
                {
                  Console.WriteLine("Invalid entry for date of birth");
                }
            }
            else
            {
                 Console.WriteLine("Invalid entry for employe name");

            }
            else
            {
                 Console.WriteLine("Invalid entry for employee ID");
            }
         }
    }
} 