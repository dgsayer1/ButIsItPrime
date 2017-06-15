using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButIsItPrime
{
    public class Output
    {
        public void Good(string result)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{result} is a prime number\r\n");
        }

        public void Bad(string result)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{result} is not a prime number\r\n");
        }

        public void Result(bool good, string result)
        {
            if (good)
            {
                Good(result);
            }
            else
            {
                Bad(result);
            }
        }

        public void Help()
        {
            Console.WriteLine("But Is It Prime?");
            Console.WriteLine("Usage:");
            Console.WriteLine("     butisitprime.exe [numberUnderTest]");
            Console.WriteLine("          e.g.: butisitprime.exe 4");
            Console.WriteLine("                will indicate whether 4 is a prime number");
            Console.WriteLine("\r\n");
            Console.WriteLine("     butisitprime.exe [numberUnderTest] [checkTheNextXNumbers]");
            Console.WriteLine("          e.g.: butisitprime.exe 4 100");
            Console.WriteLine("                will return whether 4 is a prime number and output whether the next 100 are prime or not");
            Console.WriteLine("\r\n");
            Console.WriteLine("     butisitprime.exe [numberUnderTest] nextprime");
            Console.WriteLine("          e.g.: butisitprime.exe 4 nextprime");
            Console.WriteLine("                will return the next prime number from 4");
            Console.WriteLine("\r\n");
            Console.WriteLine("     butisitprime.exe [numberUnderTest] next [xNumberOfPrimeNumbers]");
            Console.WriteLine("          e.g.: butisitprime.exe 4 next 100");
            Console.WriteLine("                will return whether 4 is a prime number and the next X number of Prime numbers");




        }
    }
}
