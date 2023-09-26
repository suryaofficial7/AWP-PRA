// Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we create 4 variable to store user inout
            int a, b, c, d;
            //result to store product of abcd
            int result;
            Console.WriteLine("Enter Number 1 :");
            a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Number 2 :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 3 :");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 4 :");
            d = Convert.ToInt32(Console.ReadLine());

            //calculationg
            result = a * b * c * d;
            //displaying 
            Console.WriteLine("Product of A b C D is :" + result);

            //waiting
            Console.ReadLine();
        }
    }
}
