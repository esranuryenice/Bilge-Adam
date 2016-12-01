using System;

using System.Numerics;

namespace _100Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            do
            {
                factorial *= n;
                n--;
            } while (n>0);
            Console.WriteLine("n! = " + factorial);
            Console.ReadKey();
        }

    }
}
