using System;
using System.Collections.Generic;
using System.Text;
namespace demo12

{
    class Author
    {
        static void Main(string[] args)
        {
            Array objAuthurID = Array.CreateInstance(typeof(int), 3);
            Array objAuthurNames = Array.CreateInstance(typeof(string), 3);
            Array objAddress = Array.CreateInstance(typeof(string), 3);
            Array objState = Array.CreateInstance(typeof(string), 3);
            string input = "";
            for (int i = 0; i < objAuthurNames.Length; i++)
            {
                Console.Write("Enter the ID of authur:");
                input = Console.ReadLine();
                objAuthurID.SetValue(Convert.ToInt32(input), i);
                Console.Write("Enter the ID of authur:");
                input = Console.ReadLine();
                objAuthurNames.SetValue(input, i);
                Console.Write("Enter the ID of authur:");
                input = Console.ReadLine();
                objAddress.SetValue(input, i);
                Console.Write("Enter the ID of authur:");
                input = Console.ReadLine();
                objState.SetValue(input, i);
                Console.WriteLine();
            }
            Console.WriteLine("\nDetails of the authurs :\n");
            Console.WriteLine("Authru ID\tName\t\tAddresst\t\tState");
            for (int i = 0; i <= objAuthurNames.GetUpperBound(0); i++)
            {
                Console.Write(objAuthurID.GetValue(i) + "\t\t");
                Console.Write(objAuthurNames.GetValue(i) + "\t");
                Console.Write(objAddress.GetValue(i) + "\t");
                Console.WriteLine(objState.GetValue(i));
            }
            Array.Sort(objAuthurNames);
            Console.WriteLine("\nAuthur names after sorting :\n");
            for (int i = 0; i <= objAuthurNames.GetUpperBound(0); i++)
            {
                Console.WriteLine(objAuthurNames.GetValue(i) + "\t");

            }
        }
    }
}