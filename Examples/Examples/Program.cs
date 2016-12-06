using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region foreach

            //int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            //foreach (int i in numbers)
            //{
            //    Console.Write(" " + i);
            //}
            //Console.WriteLine();

            //string[] towns = { "London", "Paris", "Milan", "New York" };
            //foreach (string town in towns)
            //{
            //    Console.Write(" " + town);
            //}

            //Console.ReadKey();
            #endregion

            #region factorial100

            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //BigInteger factorial = 1;

            //do
            //{
            //    factorial *= n;
            //    n--;
            //} while (n > 0);
            //Console.WriteLine("n! = " + factorial);
            //Console.ReadKey();

            #endregion

            #region reverseTheNumber
            // Get a Number and Display the Number with its Reverse

            //int num, reverse = 0;
            //Console.WriteLine("Enter a Number : ");
            //num = int.Parse(Console.ReadLine());
            //while (num != 0)
            //{
            //    reverse = reverse * 10;
            //    reverse = reverse + num % 10;
            //    num = num / 10;
            //}
            //Console.WriteLine("Reverse of Entered Number is : " + reverse);
            //Console.ReadLine();

            #endregion

            #region binaryTriangle

            //int p, lastInt = 0, input;
            //Console.Write("Enter the Number of Rows : ");
            //input = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= input; i++)
            //{
            //    for (p = 1; p <= i; p++)
            //    {
            //        if (lastInt == 1)
            //        {
            //            Console.Write("0");
            //            lastInt = 0;
            //        }
            //        else if (lastInt == 0)
            //        {
            //            Console.Write("1");
            //            lastInt = 1;
            //        }
            //    }
            //    Console.Write("\n");
            //}
            //Console.ReadLine();



            #endregion

            #region numberOf1s

            //int m, count = 0;
            //Console.WriteLine("Enter the Limit : ");
            //m = int.Parse(Console.ReadLine());
            //int[] a = new int[m];
            //Console.WriteLine("Enter the Numbers :");
            //for (int i = 0; i < m; i++)
            //{
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (int o in a)
            //{
            //    if (o == 1)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Number of 1's in the Entered Number : ");
            //Console.WriteLine(count);
            //Console.ReadLine();

            #endregion

            #region conditionalParsing

            string str = Console.ReadLine();

            int number;

            bool parseSuccess = Int32.TryParse(str, out number);

            Console.WriteLine(parseSuccess ? "The square of the number is "+ number * number + "." : "Invalid number!");

            Console.ReadKey();
            #endregion
        }
    }
}
