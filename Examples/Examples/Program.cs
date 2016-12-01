using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region foreach

            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            string[] towns = { "London", "Paris", "Milan", "New York" };
            foreach (string town in towns)
            {
                Console.Write(" " + town);
            }

            Console.ReadKey();
            #endregion
        }
    }
}
