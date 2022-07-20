using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = "Great Britain";

            Console.WriteLine(country.FirstLetterLower());

            List<string> cities = new List<string>();
            cities.Add("Seoul");
            cities.Add("Beijing");
            cities.Add("Berlin");
            cities.Add("Istanbul");
            cities.Add("Seoul");
            cities.Add("Istanbul");
            cities.Add("Paris");

            List<string> result = cities.RemoveDuplicate();
            foreach (string city in result)
                Console.WriteLine(city);
        }
    }
}
