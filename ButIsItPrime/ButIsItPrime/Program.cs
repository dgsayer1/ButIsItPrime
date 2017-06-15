using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButIsItPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate Calculate = new Calculate();
            Output Output = new Output();
            Stopwatch watcher = new Stopwatch();

            watcher.Start();

            if (args.Length == 0)
            {
                Output.Help();
            }

            if (args.Length >= 1)
            {
                double.TryParse(args[0], out double numberUnderTest);

                bool isItPrime;
                int i = 0;

                if (args.Length == 1)
                {
                    isItPrime = Calculate.IsThisAPrimeNumber(numberUnderTest);

                    Output.Result(isItPrime, numberUnderTest.ToString());

                }

                if (args.Length == 2)
                {
                    if (args[1].ToLower() == "nextprime")
                    {
                        do
                        {
                            isItPrime = Calculate.IsThisAPrimeNumber(numberUnderTest);
                            Output.Result(isItPrime, numberUnderTest.ToString());
                            numberUnderTest++;
                            i++;

                            if (i == 100)
                            {
                                Console.WriteLine($"We've checked the next {i} numbers and still couldn't find a prime number. Didn't want to take up all your RAM so we stopped!!");
                            }

                        } while (isItPrime == false);
                    }


                    else if (int.TryParse(args[1], out int checkTheNextXNumbers))
                    {
                        while (checkTheNextXNumbers > 0)
                        {
                            isItPrime = Calculate.IsThisAPrimeNumber(numberUnderTest);
                            Output.Result(isItPrime, numberUnderTest.ToString());

                            numberUnderTest++;
                            checkTheNextXNumbers--;
                        }
                    }

                }

                if (args.Length == 3)
                {
                    if (args[1].ToLower() == "next")
                    {
                        int.TryParse(args[2], out i);

                        do
                        {
                            isItPrime = Calculate.IsThisAPrimeNumber(numberUnderTest);
                            if (isItPrime)
                            {
                                Output.Good(numberUnderTest.ToString());
                                i--;
                            }
                            numberUnderTest++;

                        } while (i > 0);
                    }

                }

                if (args.Length >= 4)
                {
                    Console.WriteLine("Not sure what you're passing, ButIsItPrime.exe only takes a maximum of 3 arguments.");
                }
            }

            watcher.Stop();

            string elapsedTime = watcher.Elapsed.Milliseconds.ToString();
            Console.WriteLine($"This took {elapsedTime} milliseconds to complete.");
        }
    }
}
