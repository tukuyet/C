using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exception_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = "Great Britain";

            Console.WriteLine(country.FirstLetterLower());

            List<string> cities = new List<string>();
            cities.Add("Seoul");
            cities.Add("Be");
            cities.Add("Seoul");
            cities.Add("Seoul");
            cities.Add("Seoul");
            cities.Add("Seoul");
            cities.Add("Seoul");
        }
    }
}