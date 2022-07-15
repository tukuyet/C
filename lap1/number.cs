/*this program demonstrates the the numeric formating in C#*/
using System;
class NumberFormat 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Currency formating - {0:C} {1:C4}", 88.8,888.8);
        Console.WriteLine("integer fomating - {0:D5} ",88);
        Console.WriteLine("Exponetial fomating - {0:E}",888.8);
        Console.WriteLine("Fixed-point formating - {0:F3} ",888.8888);
        Console.WriteLine("General formating - {0:G}",888.8888);
        Console.WriteLine("Number formaing - {0:N} ",8888888.8);
        Console.WriteLine("Hexadecimal formating - {0:X4} ",88);


    }
}