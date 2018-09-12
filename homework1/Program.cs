using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {

        static void Main(string[] args)
        {
           

                string s = "";
                double a = 0;
                double b = 0;
                double c = 0;
                Console.Write("Please input the first number:");
                s = Console.ReadLine();
                a = double.Parse(s);
                Console.Write("Plesae input the second number:");
                s = Console.ReadLine();
                b = double.Parse(s);
                c = a * b;
            Console.WriteLine("the product of " + a + " and " + b + " is " + c);
        }
    }
}
