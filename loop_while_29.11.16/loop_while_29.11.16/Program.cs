using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopWhile_29._11._16_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [0,9] numbers

            //Console.Write("Factorial: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int counter = 1;
            //int total = 1;

            //while (counter <= n)
            //{

            //    total *= counter;

            //    counter++;

            //}
            //Console.WriteLine("\nResult: "+total);
            //Console.ReadKey();

            #endregion

            #region guessthenumber

            Console.WriteLine("Guess my number [1-10].");

            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 11);
            int guess;
            int counter = 0;

            while (true)
            {
                counter++;
                Console.Write("What is your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNumber)
                {
                    break;
                }
            }

            Console.WriteLine("\nCongratulations! This was your {0}th step.", counter);
            Console.ReadKey();

            #endregion

        }
    }
}
//HW: 10 tabanında bir sayı gir 2lik tabana çevirsin
//herhangi bir tabandan herhangi bir tabana çevirme