using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
    
{
    class Program
    {
        static void Main(string[] args)
        {
            #region days

            //start:
            //Console.Write("enter a number btw 1-7: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        goto start;
            //}

            //Console.ReadKey();

            #endregion

            #region seasons

            //start:
            //    int month = Convert.ToInt32(Console.ReadLine());

            //    switch (month)
            //    {
            //        case 12:
            //        case 1:
            //        case 2:
            //            Console.WriteLine("Winter");
            //            break;

            //        case 3:
            //        case 4:
            //        case 5:
            //            Console.WriteLine("Spring");
            //            break;
            //        case 6:
            //        case 7:
            //        case 8:
            //            Console.WriteLine("Summer");
            //            break;
            //        case 9:
            //        case 10:
            //        case 11:
            //            Console.WriteLine("Autumn");
            //            break;

            //        default:
            //            Console.WriteLine("wrong entry");
            //            break;
            //    }

            //    if (month != 0)
            //    {
            //        goto start;
            //    }

            #endregion

            #region operations

            //double result = 0;
            //Console.Write("Number 1: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Number 2: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Operation: ");
            //char op = Convert.ToChar(Console.ReadLine());


            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        break;
            //    default:
            //        Console.WriteLine("wrong entry");
            //        break;
            //}

            //Console.WriteLine("\nResult: " + result);
            //Console.ReadKey();

            #endregion

            #region bank

            Console.Write("Welcome \n" +
                "1-> Loan Payment\n" +
                "2-> Deposit money\n" +
                "3-> Withdraw cash\n" +
                "4-> Other Transactions\n" +
                "? ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("\nLoan Payment");
                    break;
                case 2:
                    Console.WriteLine("\nDeposit money");
                    break;
                case 3:
                    Console.WriteLine("\nWithdraw cash");
                    break;
                case 4:
                    Console.WriteLine("\nOther Transactions");
                    break;
                default:
                    Console.WriteLine("Please enter btw 1-4 !!!");
                    break;
            }

            Console.ReadKey();

            #endregion



        }
    }
}

//ctrl+K+D hizalamak ve düzeltmek için