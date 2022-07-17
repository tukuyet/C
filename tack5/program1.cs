using System;
using System.Collections.Gereric;
using System.Linq;
using System.Text;

namespace ImlicitlyTypedAnonymous_Type
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Anonymous Type
            var p1 =new {Name ="A", Price =3 };
            Console.WriteLine(" Name = {0}\nPrice = {1}",
                p1.name.ToLower(), p1.Price);
            
            //Imlicitly type local variables
            var i=5;
            var s = "hello";
            Console.WriteLine("type of i:" + i.GerTyPe());
            //s is a string 
            Console.WriteLine("First letter of s:" + s.Substring(1,1));
            Console.Readline();
            
        }
    }
}