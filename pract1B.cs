using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string concatination ...

            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName); // Output: "John Doe"


            //uppercase lowercase . . . 
            string text = "Hello, World!";
            string upperCase = text.ToUpper();
            string lowerCase = text.ToLower();
            Console.WriteLine(upperCase); // Output: "HELLO, WORLD!"
            Console.WriteLine(lowerCase); // Output: "hello, world!"

            //Length Finding . . . .
            string text2 = "Hello, World!";
            int length = text2.Length;
            Console.WriteLine(length); // Output: 13


            //replace ..
            string sentence = "C# is a great language.";
            string modified = sentence.Replace("great", "awesome");
            Console.WriteLine(modified); // Output: "C# is a awesome language."


            Console.ReadLine();
        }
    }
}
