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

            #region MyRegion

            //3 dicek -- çarş ..devam etme seçeneği ile

            string[] days = new string[] {"Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar"};

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }

            bool answer = true;

            while (answer)
            {
                Console.Write("Number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(days[number-1]);

                Console.WriteLine("Do you want to continue ? (Y/N)");
                string ans = Convert.ToString(Console.ReadLine());

                if (true)
                {

                }
            }



            Console.ReadKey();


            #endregion
        }
    }
}
