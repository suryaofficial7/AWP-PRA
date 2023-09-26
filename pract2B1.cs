using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract2B1
{
    internal class Program
    {

        void add(int a, int b) {
            int val = a + b;
            Console.WriteLine("a+b = " + val);
        }


        void add(int a, int b , int c)
        {
            int val = a + c + b;
            Console.WriteLine("a+b+c = " + val);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Function Overloading : ");
            Program p = new Program();

            p.add(1, 2);
            p.add(1, 2,3);

            Console.ReadLine();

        }
    }
}
