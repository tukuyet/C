using System;
using System.Collections.Gereric;
using System.Linq;
using System.Text;

namespace ValueAndReferenceType
{
    class testA
    {
        public String name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int z =10;
            String str = " Hello woeld!";
            Console.WriteLine("****Test value type:");
            Console.WriteLine("the value of z beforre: " +z);
            changeValue(z);
            Console.WriteLine("the value of z after: "+z);

            Console.WriteLine("****Test reference type:");
            testA a = new testA();
            a.name ="not changed!";
            Console.WriteLine("The value of str bfore:"+ a.name);
            changeValue2(a);
            Console.WriteLine("The value of str afeter:"+ a.name);

            Console.Readline();
        
        }
        public static void changeValue(int k)
        {
            k=10;
        }
        public static void changeValue2(testA v)
        {
            v.name ="changed it";
        }

    }
}