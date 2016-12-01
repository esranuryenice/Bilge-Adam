using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengisuGultekinSoru3
{
    class Program
    {
        static void Main(string[] args)
        {
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
                                if (j == 0 || j == 4)
                                {
                                    Console.Write("* ");
                                }
                                else if (i == 0 || i == 4)
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
                                if (j == 0 || j == 7)
                                {
                                    Console.Write("* ");
                                }
                                else if (i == 0 || i == 4)
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
                                if (i == 1 && (j == 1 || j == 4))
                                {
                                    Console.Write("* ");
                                }
                                else if (i == 0 && i + j > 1)
                                {
                                    Console.Write("* ");
                                }
                                else if (i == 2 && i + j < 6)
                                {
                                    Console.Write("* ");
                                }
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

                Console.Write("\nDevam etmek ister misiniz (E/H)? ");
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
