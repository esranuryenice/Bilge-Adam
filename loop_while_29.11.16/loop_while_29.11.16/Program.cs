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
            //ulong n = Convert.ToUInt64(Console.ReadLine());
            //ulong counter = 1;
            //ulong total = 1;

            //while (counter <= n)
            //{

            //    total *= counter;

            //    counter++;

            //}
            //Console.WriteLine("\nResult: " + total);
            //Console.ReadKey();

            #endregion

            #region guessthenumber

            //Console.WriteLine("Guess my number [1-10].");

            //Random rnd = new Random();

            //int randomNumber = rnd.Next(1, 101);
            //int guess;
            //int counter = 0;

            //while (true)
            //{
            //    counter++;
            //    Console.Write("What is your guess: ");
            //    guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess < randomNumber)

            //        Console.WriteLine("UP UP");

            //    else if (guess > randomNumber)

            //        Console.WriteLine("DOWN DOWN");

            //    else
            //        break;

            //}

            //Console.WriteLine("\nCongratulations! This was your {0}th step.", counter);
            //Console.ReadKey();

            #endregion

            #region DoWanttoCountinue?

            //bool Continue = true;

            //while (Continue)
            //{
            //    Console.Write("First number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Second number: ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Operation: ");
            //    char operation = Convert.ToChar(Console.ReadLine());

            //    double result = 0;


            //    switch (operation)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;
            //        case '-':
            //            result = num1 - num2;
            //            break;
            //        case '*':
            //            result = num1 * num2;
            //            break;
            //        case '/':
            //            result = num1 / num2;
            //            break;
            //        default:
            //            Console.WriteLine("\nwrong entry!!!");
            //            break;
            //    }

            //    Console.WriteLine("Result: {0}",result);

            //    Console.Write("Do you want to continue (Y/N) ? ");
            //    string answer = Console.ReadLine(); 

            //    if (answer == "y" || answer == "Y" || answer == "yes")

            //        Continue = true;

            //    else
            //        Continue = false;
            // }

            #endregion

            #region even-odd

            Console.WriteLine("enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a operation: ");
            string operation = Convert.ToString(Console.ReadLine());

            int counter = 0;
            long resultOfSum = 0;
            long resultOfProduct = 1;


            switch (operation)
            {
                case "+":
                    while (counter <= num)
                    {
                        if (counter % 2 == 1)
                        {
                            resultOfSum += counter;
                            
                        }
                        counter++;

                    }
                    Console.WriteLine("Result: " + resultOfSum);
                    break;

                case "*":
                    while (counter <= num)
                    {
                        if (counter % 2 == 1)
                        {

                            resultOfProduct *= counter;

                        }
                        counter++;

                    }
                    Console.WriteLine("Result: " + resultOfProduct);
                    break;

                default:
                    Console.WriteLine("What is " +operation + " ?");
                    break;
            }



            Console.ReadKey();
            #endregion
        }
    }
}
//HW: 10 tabanında bir sayı gir 2lik tabana çevirsin
//herhangi bir tabandan herhangi bir tabana çevirme