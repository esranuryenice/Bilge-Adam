using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region soru2 
            //[1,n] arasındaki sayıların toplamı ve tersten yazılışı

            //Console.Write("Lütfen sayı giriniz: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int total = 0;

            //for (int counter = 1; counter <= number; counter++)
            //{
            //    total = total + counter;
            //}

            //Console.WriteLine("\n[1,{0}] aralığındaki sayıların toplamı: {1}", number, total);

            //Console.WriteLine("\nSayıların tersten yazılışı: \n");

            //for (int i = number; i > 0; i--)
            //{

            //    Console.Write(i + " ");
            //}

            //Console.ReadKey();

            #endregion


            #region soru3

            bool answer = true;

            while (answer)
            {
                Console.Write("Lütfen bir şekil seçiniz (kare / dikdörtgen / paralelkenar): ");
                string shape = Convert.ToString(Console.ReadLine());

                Console.WriteLine();
                switch (shape)
                {
                    case "kare":

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (i == 0 || i == 4 || j == 0 || j == 4)
                                {
                                    Console.Write("* ");
                                }                                
                                else
                                    Console.Write("  ");
                            }
                            Console.WriteLine();

                        }
                        break;

                    case "dikdörtgen":

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if (i == 0 || i == 4 || j == 0 || j == 7)
                                {
                                    Console.Write("* ");
                                }                                
                                else
                                    Console.Write("  ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "paralelkenar":

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if ((i == 1 && (j == 1 || j == 4)) || (i == 0 && j > 1) || (i == 2 && j < 4))
                                {
                                    Console.Write("* ");
                                }
                                //else if (i == 0 && i + j > 1) 
                                //{
                                //    Console.Write("* ");
                                //}
                                //else if (i == 2 && i + j < 6) 
                                //{
                                //    Console.Write("* ");
                                //}
                                else
                                    Console.Write("  ");
                            }
                            Console.WriteLine();
                        }
                        break;


                    default:
                        Console.WriteLine("Error: Yanlış giriş yaptınız !!!");
                        break;
                }

                Console.WriteLine("\nDevam etmek ister misiniz (E/H)? ");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "E" || userAnswer == "e" || userAnswer == "evet")
                {
                    answer = true;
                    Console.WriteLine();
                }
                else
                    answer = false;
            }

            #endregion





        }
    }
}
