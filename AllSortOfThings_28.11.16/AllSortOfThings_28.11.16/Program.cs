using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allsortofthings_28._11._16_
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = "hello";

            //int number = 10;
            //number = number + 1;
            //number++;

            //int total = 10;
            ////total = total + number; //ctrl+k+c

            //total += number;
            //total -= number;
            //total *= number;
            //total /= number;


            //Console.WriteLine(total);

            ////Console.WriteLine(word); //cw tab+tab
            //Console.ReadKey();

            double num1 = 10;
            double num2 = 20;
            double num3 = 30;

            Console.WriteLine("\nnumber 1: {0}\nnumber 2: {1}\nnumber 3: {2}", num1, num2, num3);

            num1 += num2;
            num1 += num3;
            num3 += num1;

            num3 /= 3;
            num1 /= 2;
            num1 -= num2;

            Console.WriteLine("\nnumber 1: {0}\nnumber 2: {1}\nnumber 3: {2}", num1, num2, num3);

            num1 = num3 % num2;

            Console.ReadKey();



        }
    }
}
