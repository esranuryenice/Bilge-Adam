using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1examples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Algoritma
            /*
            Belirli bir problemi çözen veya amacı gerçekleştiren yöntemlere algoritma denir.
            
            Bir algoritmanın temel özellikleri:
            * Başlangıcı ve sonu olmalı
            * Adım adım ilerlemeli
            * Basit ve anlaşılır olmalı

            Faktöriyel Hesaplama
            Adım 1. Başla
            Adım 2. sayi Gir
            Adım 3. sayac = 1 fakto = 1
            Adım 4. fakto = fakto * sayac
            Adım 5. sayac++
            Adım 6. sayac <= sayi ise 4. adıma dön değilse 7. adıma git
            Adım 7. fakto yu yazdır.
            Adım 8. Bitir
            */
            #endregion

            #region 4Islem
            /*4 işlem seç ve şeklini yıldızlar ile ekrana yansıt ve kullanıcı istediği sürece devam et*/

            //bool answer = true;

            //while (answer)
            //{
            //    Console.Write("Please choose an operation (+ - * /): ");
            //    char operation = Convert.ToChar(Console.ReadLine());

            //    Console.WriteLine();
            //    switch (operation)
            //    {
            //        case '+':

            //            for (int i = 0; i < 5; i++)
            //            {
            //                for (int j = 0; j < 5; j++)
            //                {
            //                    if (i == 2)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else if (i != 2 && j == 2)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else
            //                        Console.Write(" ");
            //                }
            //                Console.WriteLine();

            //            }
            //            break;

            //        case '-':

            //            for (int i = 0; i < 5; i++)
            //            {
            //                for (int j = 0; j < 5; j++)
            //                {
            //                    if (i == 2)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else
            //                        Console.Write(" ");
            //                }
            //                Console.WriteLine();
            //            }
            //            break;

            //        case '*':

            //            for (int i = 0; i < 5; i++)
            //            {
            //                for (int j = 0; j < 5; j++)
            //                {
            //                    if (i == j)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else if (i + j == 4)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else
            //                    {
            //                        Console.Write(" ");
            //                    }
            //                }
            //                Console.WriteLine();
            //            }
            //            break;

            //        case '/':

            //            for (int i = 0; i < 5; i++)
            //            {
            //                for (int j = 0; j < 5; j++)
            //                {
            //                    if (i == 2)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else if ((i == 1 || i == 3) && j == 2)
            //                    {
            //                        Console.Write("*");
            //                    }
            //                    else
            //                        Console.Write(" ");
            //                }
            //                Console.WriteLine();
            //            }

            //            break;
            //        default:
            //            Console.WriteLine("Error: Wrong Entry !!!");
            //            break;
            //    }

            //    Console.WriteLine("\nDo you want to continue (Y/N)? ");
            //    string userAnswer = Console.ReadLine();

            //    if (userAnswer == "Y" || userAnswer == "y" || userAnswer == "yes")
            //    {
            //        answer = true;
            //        Console.WriteLine();
            //    }
            //    else
            //        answer = false;
            //}
            #endregion

            #region usAlma

            //Console.Write("Enter the base: ");
            //int Base = Convert.ToInt32(Console.ReadLine());

            //int power = 0;

            //bool isItPositive = true;

            //while (isItPositive)
            //{
            //    Console.Write("Enter the power: ");
            //    power = Convert.ToInt32(Console.ReadLine());

            //    if (power <= 0)

            //        isItPositive = true;

            //    else
            //        isItPositive = false; 
            //}
            //int result = 1;
            //for (int i = 0; i < power; i++)
            //{

            //    result *= Base;
            //}

            //Console.WriteLine("{0}^{1} = {2}", Base, power, result);
            //Console.ReadKey();

            #endregion

            #region randomMatrix

            //Random rnd = new Random();
            //int randomNumber;

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        randomNumber = rnd.Next(1, 9);
            //        Console.Write(randomNumber + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            #endregion

            #region prime[n..m]

            //int n = 3;
            //int m = 50;

            //for (int num = n; num <= m; num++)
            //{
            //    bool prime = true;
            //    int divider = 2;
            //    int maxDvider = (int)Math.Sqrt(num);
            //    while (divider <= maxDvider)
            //    {
            //        if (num%divider == 0)
            //        {
            //            prime = false;
            //            break;
            //        }
            //        divider++;
            //    }
            //    if (prime)
            //    {
            //        Console.Write(" " + num);
            //    }
            //}

            //Console.ReadKey();

            #endregion

            #region isItPrime

            //int num = 1789;
            //bool prime = true;
            //int divider = 2;
            //int maxDvider = (int)Math.Sqrt(num);
                        
            //while (prime && (divider <= maxDvider))
            //{
            //    if (num % divider == 0)
            //    {
            //        prime = false;

            //    }
            //    divider++;
            //}
            //Console.WriteLine("Prime? " + prime);

            //Console.ReadKey();

            #endregion

            #region triangleWithNumbers

            //int n = 7;
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #endregion

            #region triangleWithStars

            //int n = 7;
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write("*" + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #endregion
        }
    }
}
