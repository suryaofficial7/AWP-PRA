using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract2B2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to money conveter  - -- - - ");

            Console.WriteLine("1.Rs - USD");
            Console.WriteLine("2.USD - Rs");

            int cho = Convert.ToInt32(Console.ReadLine());


            if (cho == 1) {
                Console.WriteLine("Enter RS : ");
                int rs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(rs*80);
            }


            else if ( cho == 2) {
                Console.WriteLine("Enter USD : ");
                int rs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(rs/80);
            }
            else {

                Console.WriteLine("Chooose Cooorect Option");
            }

            Console.ReadLine();
        }
    }
}
