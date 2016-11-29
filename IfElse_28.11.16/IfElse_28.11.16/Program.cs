using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse_28._11._16_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region comparison
            //int num1 = 5;
            //int num2 = 2;

            //if (num1 > num2)

            //    Console.WriteLine("number 1 is greater");

            //else if (num1 < num2)

            //    Console.WriteLine("number 2 is greater");

            //else

            //    Console.WriteLine("numbers are equal");

            //Console.ReadKey();
            #endregion

            #region even-odd

            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("\neven");
            //}
            //else
            //{
            //    Console.WriteLine("\nodd");
            //}
            //Console.ReadKey(); //bunun kısayolunu bul!

            #endregion

            #region arttırma

            //int a = 5;
            //int b = a++;

            ////int b = ++a;


            //Console.WriteLine(a + " - " + b);
            //Console.ReadKey(); //readkey ile readline arasındaki fark ne?

            #endregion

            #region 4operations

            //int num1, num2;
            //char operation;
            //string result;

            //Console.Write("number 1\t: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("number 2\t: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("operation\t: ");
            //operation = Convert.ToChar(Console.ReadLine());

            //if  (operation == '+')
            //{

            //    result = (num1 + num2).ToString();
            //    //Console.WriteLine("Result: {0}", num1 + num2);

            //}
            //else if (operation == '-')
            //{
            //    if (num1 >= num2)
            //    {
            //        result = (num1 - num2).ToString();
            //        //Console.WriteLine("Result: {0}", num1 - num2);
            //    }


            //    else
            //    {
            //        result = (num2 - num1).ToString();
            //        //Console.WriteLine("Result: {0}", num2 - num1);
            //    }           

            //}

            //else if (operation == '/')
            //{
            //    if (num1 >= num2)

            //        result = (num1 / num2).ToString();

            //    else

            //        result = (num2 / num1).ToString();
            //}
            //else if (operation == '*')
            //{

            //    result = (num1 * num2).ToString();  

            //}

            //else
            //{
            //    result = "hatalı girdiniz";
            //}

            //Console.WriteLine("Result \t\t: " + result);


            //Console.Read();

            #endregion

            #region midterm-final
            //final %60 vize %40 60ve60dan fazlaysa geçsin yoksa kalsın AA >=85, BA 84,80 , BB 75,79, CB 74,70, CC 60,69 //DC 50,59 DD 40,49 FF 40,0
            //int midterm;
            //int final;


            //Console.Write("Midterm: ");
            //midterm = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Final: ");
            //final= Convert.ToInt32(Console.ReadLine());

            //double total = midterm * 0.4 + final * 0.6;
            //Console.WriteLine("Total: " + total);
            //if (total >= 60)
            //{
            //    Console.WriteLine("Passed");
            //    if (total <= 69)
            //    {
            //        Console.WriteLine("CC");
            //    }
            //    else if (total >= 70 && total <= 74)
            //    {
            //        Console.WriteLine("CB");
            //    }
            //    else if (total >= 75 && total <= 79)
            //    {
            //        Console.WriteLine("BB");
            //    }
            //    else if (total >= 80 && total <= 84)
            //    {
            //        Console.WriteLine("BA");
            //    }
            //    else
            //    {
            //        Console.WriteLine("AA");
            //    }

            //}
            //else 
            //{
            //    Console.WriteLine("Failed");

            //    if (total >= 50 && total <= 59)
            //    {
            //        Console.WriteLine("DC");
            //    }
            //    else if (total >= 40 && total <= 49)
            //    {
            //        Console.WriteLine("DD");
            //    }
            //    else
            //    {
            //        Console.WriteLine("FF");
            //    }
            //}


            //Console.ReadLine();

            #endregion

            #region salaryTax

            Console.Write("Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            double tax = 0;


            if (salary <= 1000)
            {
                tax = salary * 0.1;
            }
            else if (salary <= 2500)
            {
                tax = salary * 0.2;
            }
            else if (salary <= 5000)
            {
                tax = salary * 0.3;
            }
            else
            {
                tax = salary * 0.5;
            }

            Console.WriteLine("Your tax payment is " + tax);
            Console.ReadLine();

            #endregion

        }
    }
}

/* Read()     -> Accept the string value and return the string value.
 * ReadLine() -> Accept the string and return Integer
 * ReadKey()  ->  Accept the character and return Character 
 
1.The above mentioned three methods are mainly used in Console application and these are used for return the different values .
2.If we use Read line or Read() we need press Enter button to come back to code.
3.If we using Read key() we can press any key to come back code in application*/
