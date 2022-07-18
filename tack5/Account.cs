/*
*Account.cs
*
*Copyright Nguyen Anh Tuan . All right reserved.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    ///<summary>
    ///
    ///the program demonstrates the use of jump statements.
    ///
    ///Class Account accepts and displays the details of accounts using the break, continue , goto, and return statement.
    ///</suamary>
    class Account
    {
        ///<summary>
        ///the entry point for the application.
        ///</summary>
        ///<param name="args">A liat of command line Arguments </param>
        static void Main(string[] args)
        {
            //Arrays of integer to store customer ID and 
            int[] customerID = new int[3];
            int[] accountNumber = new int[3];

            //Array of string to store account type
            string[] accountType = new string[3];

            //Array of datetime to store the date on which the accout is opened
            DateTime[] dateOpened = new DateTime[3];

            //Array of double to store deposit and balance 
            double[] deposit = new double[3];
            double[] balance = new double[3];

            //Integer variable to store the account number entered
            int choice = 0;

            int i = 0;
            bool found = false;

        // Accepting the details of account using goto and return statements
        accept:
            {
                Console.Write("Enter the ID of cistomer:");
                customerID[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter account number:");
                accountNumber[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter account type [FDixed/Savings]: (F/S)");
                accountType[i] = Console.ReadLine();
                Console.Write("Enter the date of opening account [MM/DD/YYYY]:");
                dateOpened[i] = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the amount deposited :");
                deposit[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                if (deposit[i] <= 0)
                {
                    Console.WriteLine("Invalid Data Entry");
                    return;

                }
                else
                {
                    // Calculating the balance 
                    balance[i] = balance[i] + deposit[i];
                }
                i++;
            }
            if (i < customerID.Length)
            {
                goto accept;
            }
            // Displaying the account details
            Console.WriteLine("Account Detail :\n");
            Console.WriteLine("ID\tA/c No.\tA/c Type Opening Date\tDeposit($) Balance($)");
            for (i = 0; i < customerID.Length; i++)
            {
                Console.Write("{0}\t{1} \t", customerID[i], accountNumber[i]);
                Console.Write("{0}\t {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                Console.WriteLine("{0}\t   {1}", deposit[i], balance[i]);
            }
            // Displaying the details of alll except those that werw created today
            Console.WriteLine("\n\nAccount Details : \n");
            Console.WriteLine("ID\tA/c No.\tA/c Type Opening Date\tDeposit($) Balance($)");
            DateTime today = DateTime.Today.Date;
            for (i = 0; i < customerID.Length; i++) 
            {
                //caculate the diffierence between date
                int num = (today.Subtract(dateOpened[i])).Days;
                if (num == 0)

                    continue;


                else
                {
                    Console.Write("{0}\t{1} \t", customerID[i], accountNumber[i]);
                    Console.Write("{0}\t {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                    Console.WriteLine("{0}\t     {1}", deposit[i], balance[i]);
                }
            }

            // Accepting an account number to view details 
            Console.Write("\nEnter the account number whose details youy want to wiew :");
            choice = Convert.ToInt32(Console.ReadLine());

            //Displaying the account detaols according to the choice enrered using break statement 
            for (i = 0; i < accountNumber.Length; i++)
            {
                if (accountNumber[i] == choice)
                {
                    found = true;

                    Console.WriteLine("Recor Found!");
                    Console.WriteLine("ID\tA/c No.\tA/c Type Opening Date\tDeposit($) Balance($)");
                    Console.WriteLine("{0}\t{1} \t", customerID[i], accountNumber[i]);
                    Console.Write("{0}\t {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                    Console.WriteLine("{0}\t     {1}", deposit[i], balance[i]);
                    break;
                }
            }
            if (!found)
                Console.WriteLine("Account does noy exist");
        }
    }

}

    