using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List

            //List<int> numbers = new List<int>(); //() içine bişey yazmazsan dynamic olur!

            //numbers.Add(1);

            //numbers.AddRange(new int[] { 2, 3, 4 });

            //Console.WriteLine(numbers.Count);
            //Console.Clear();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine("{0} = {1}", i, numbers[i]);
            //}

            //Console.ReadKey();

            #endregion

            #region List2

            //int[] array = new int[2];
            //array[0] = 3;
            //array[1] = 5;

            //List<int> list = new List<int>(array);

            //Console.WriteLine("{0} tane eleman yazdıracağım.", list.Count);

            //foreach (var elm in list)
            //{
            //    Console.Write(elm + " ");
            //}

            #endregion

            #region List3

            //List<int> numbers = new List<int>(new int[] { 1903, 1904, 1905 });

            //int index = numbers.IndexOf(1903);

            #endregion

            #region List4

            //List<string> isimler = new List<string>();

            //isimler.AddRange(new string[] { "ali", "veli", "ayşe", "fatma", "hayriye" });

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region List5-Silmek

            //List<int> numbers = new List<int>();

            //numbers.Add(3);
            //numbers.Add(5);
            //numbers.AddRange(new int[] { 8, 10, 13, 3, 8 });

            ////numbers.RemoveAt(0); //girilen index silinir
            ////numbers.Remove(8); //girilen değer silinir, 1den fazla ise ilk değer silinir
            ////numbers.RemoveRange(3, 2); //aralık siler


            ////bool varmi = numbers.Contains(15); 

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine("\n\t" + item);
            //}



            //bool cevap = true;

            //while (cevap)
            //{
            //    Console.WriteLine("Hangisini silmek istersin? ");
            //    int sil = int.Parse(Console.ReadLine());

            //    Console.Clear();

            //    for (int i = 0; i < numbers.Count; i++)
            //    {
            //        bool varmi = true;

            //        while (varmi)
            //        {
            //            if (numbers.Contains(sil))
            //            {
            //                numbers.Remove(sil);
            //            }


            //            else
            //                varmi = false;
            //        }
            //    }

            //    foreach (var item in numbers)
            //    {
            //        Console.WriteLine("\n\t" + item);
            //    }

            //    Console.WriteLine("devam edelim mi? ");
            //    char input = Convert.ToChar(Console.ReadLine());

            //    if (input == 'e')
            //    {
            //        cevap = true;
            //    }
            //    else
            //        cevap = false;
            //}



            #endregion

            #region List6-find-sort

            //var result = numbers.Find(i => i > 5); //5ten büyük ilk değeri döner

            //var result = numbers.FindAll(i => i > 5); //5ten büyük tüm elemanları döner

            //var result = numbers.FindAll(i => i > 5).Count();  //5ten büyük tüm elemanların sayısını döner

            //numbers.Sort();
            //numbers.Reverse();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine("\n\t " + item);
            //}



            //Console.ReadKey();
            #endregion

            #region testenAlfabe

            //List<char> alphabet = new List<char>();

            //for (char i = 'A'; i <= 'Z'; i++)
            //{
            //    alphabet.Add(i);
               
            //}

            ////1st WAY   
            //alphabet.Reverse();
            //foreach (var item in alphabet)
            //{
            //    Console.Write(item + " ");
            //}

            ////2nd WAY
            ////alphabet.Reverse();
            ////for (int i = 0; i < alphabet.Count; i++)
            ////{
            ////    Console.Write(alphabet[i] + " ");
            ////}

            ////3rd WAY
            ////for (int i = alphabet.Count - 1; i >= 0 ; i--)
            ////{
            ////    Console.Write(alphabet[i] + " ");
            ////}

            //Console.ReadKey();

            #endregion

            #region isimler

            //List<string> names = new List<string>();

            //names.Add("hakan");
            //names.AddRange(new string[] { "irfan", "aytekin", "cemal", "merve", "yankı", "atakan" });

            //names.Sort();
            //names.Reverse();

            //foreach (var item in names)
            //{
            //    Console.WriteLine("\t" + item);
            //}

            //Console.ReadKey();
            #endregion



        }
    }
}
