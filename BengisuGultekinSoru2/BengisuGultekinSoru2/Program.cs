using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengisuGultekinSoru2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region soru2 
            //[1,n] arasındaki sayıların toplamı ve tersten yazılışı

            Console.Write("Lütfen sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int total = 0;

            for (int counter = 1; counter <= number; counter++)
            {
                total = total + counter;
            }

            Console.WriteLine("\n[1,{0}] aralığındaki sayıların toplamı: {1}", number, total);

            Console.WriteLine("\nSayıların tersten yazılışı: \n");

            for (int i = number; i > 0; i--)
            {

                Console.Write(i + " ");
            }

            Console.ReadKey();

            #endregion
        }
    }
}
