using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region firstArray

            //int[] array = new int[3];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //Console.ReadKey();

            #endregion

            #region classSize

            //Console.Write("Class size? ");
            //int size = Convert.ToInt32(Console.ReadLine());

            //string[] students = new string[size];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.Write("{0}. student's name: ", i);
            //    students[i] = Console.ReadLine();

            //}
            //Console.Clear();

            //Console.WriteLine("Students: \n");

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();
            #endregion

            #region randomNumbers [-100,100]

            //-100 100 arası random kaç tane oldg kullancı girsin kaçı poz kaçı neg ve kaçı 0 yazsın

            //Console.Write("How many numbers? ");
            //int size = Convert.ToInt32(Console.ReadLine());

            //Random rndm = new Random();

            //int[] randomNumbers = new int[size];

            //Console.Clear();

            //Console.WriteLine();
            //for (int i = 0; i < randomNumbers.Length; i++)
            //{
            //    int number = rndm.Next(-100, 101);
            //    randomNumbers[i] = number;
            //    //Console.Write(randomNumbers[i] + " ");
            //}
            //int positive = 0;
            //int negative = 0;
            //int notr = 0;

            //foreach(var i in randomNumbers)
            //{
            //    if (i > 0)
            //    {
            //        positive++;
            //    }
            //    else if (i < 0)
            //    {
            //        negative++;
            //    }
            //    else
            //        notr++;
            //}

            //Console.WriteLine("\n\nPositive numbers: " + positive);
            //Console.WriteLine("\nNegative numbers: " + negative);
            //Console.WriteLine("\nZeros: " + notr);

            //Console.ReadKey();
            #endregion

            #region correspondingDay


            //string[] days = new string[] {"Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar"};

            ////foreach (var day in days)
            ////{
            ////    Console.WriteLine(day);
            ////}

            //bool answer = true;

            //while (answer)
            //{
            //    Console.Write("\nNumber: ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(days[number - 1]);

            //    Console.Write("\nDo you want to continue (Y/N)? ");
            //    string ans = Convert.ToString(Console.ReadLine());

            //    if (ans == "Y" || ans == "y" || ans == "yes")
            //    {
            //        answer = true;
            //    }
            //    else
            //        answer = false;
            //}

            #endregion

            #region whichMonthWhichSeason

            //hangi ay hangi mevsime denk gelir user ay girsin mevsim çıksın

            string[] months = new string[] {"January","February","March","April","May","June",
                "July","August","September","October","November","December"};

            string userInputString = "";

            bool answer = true;

            while (answer)
            {
                Console.Write("Please choose 1 for entering number or 2 for entering month: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\nNumber: ");
                        int userInput = Convert.ToInt32(Console.ReadLine());

                        userInputString = months[userInput - 1];                     
                        break;

                    case 2:
                        Console.Write("\nMonth: ");
                        userInputString = Convert.ToString(Console.ReadLine());
                        
                        break;

                    default:
                        Console.WriteLine("Error: Wrong Entry !!!");
                        break;
                }

                Console.Clear();

                Console.Write("\nThe month is " + userInputString);

                for (int i = 0; i < months.Length; i++)
                {
                    if (userInputString == months[i])
                    {
                        if (i == 11 || i == 0 || i == 1)
                        {
                            Console.Write(" and the season is Winter");
                        }
                        else if (i == 2 || i == 3 || i == 4)
                        {
                            Console.Write(" and the season is Spring");
                        }
                        else if (i == 5 || i == 6 || i == 7)
                        {
                            Console.Write(" and the season is Summer");
                        }
                        else
                        {
                            Console.Write(" and the season is Autumn");
                        }

                    }
                }

                Console.Write("\n\n\nDo you want to continue (Y/N)? ");
                string userAnswer = Convert.ToString(Console.ReadLine());

                if (userAnswer == "Y" || userAnswer == "y" || userAnswer == "yes")
                {
                    answer = true;
                }
                else
                    answer = false;
            }
           


            #endregion
        }
    }
}
