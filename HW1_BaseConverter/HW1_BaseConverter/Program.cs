//HW: 10 tabanında bir sayı gir 2lik tabana çevirsin
using System;

namespace HW1_BaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
        start:

            Console.Write("Please choose base (2 or 10): ");
            string Base = Console.ReadLine();

            int digit;

            switch (Base)
            {
                case "10":

                    Console.Write("Enter a number: ");
                    int decimalNumber = Convert.ToInt32(Console.ReadLine());

                    string base2 = "";

                    while (decimalNumber > 0)
                    {

                        digit = decimalNumber % 2;

                        decimalNumber /= 2;

                        base2 = digit.ToString() + base2;

                    }
                    Console.WriteLine("Binary: {0}", base2);
                    break;

                case "2":

                    Console.Write("Enter a number: ");
                    int binaryNumber = Convert.ToInt32(Console.ReadLine());

                    int digitNumber = binaryNumber.ToString().Length;
                    double base10 = 0;

                    for (int i = 0; i < digitNumber; i++)
                    {
                        digit = binaryNumber % 10;    //sondaki basamak
                        base10 += digit * (Math.Pow(2, i));
                        binaryNumber = binaryNumber / 10;   //sondaki basamağı çıkar

                    }

                    Console.WriteLine("Decimal: {0}", base10);
                    break;

                default:

                    Console.WriteLine("\nWrong entry!!!\n");
                    goto start;

            }

            Console.ReadKey();

        }
    }
}
