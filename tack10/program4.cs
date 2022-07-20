using Instantiang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Instantiating
{
    class Program
    {
        static void Main(string[] args)
        {
            House londonHouse =
                new House { HouseName = "London Street", Members = 3 };

            Console.WriteLine("House Name: {0}, Members: {1}",
                londonHouse.HouseName, londonHouse.Members);
        }
    }
}