using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchError
{
    class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    int[] array = new int[4]; //0,1,2,3 -> 4 elemanlı
            //    Console.WriteLine(array[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("yok böle bişi");                
            //}

            //try
            //{
            //    int num = int.Parse(Console.ReadLine());
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            //finally
            //{ 
            //    //doğru ya da yanlış olsa da finally çalışıyor her durumda
            //    Console.WriteLine("Finally çalıştı");
            //}

            //try
            //{
            //    int num = int.Parse(Console.ReadLine());
            //}
            //catch (FormatException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("finally executed !");
            //}

            //try
            //{
            //    int num = int.Parse(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("finally executed !");
            //}

            try
            {
                throw new IndexOutOfRangeException();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



            Console.ReadKey();
        }
    }
}
