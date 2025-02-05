using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execption
{
    class Program
    {
        static void Main(string[] args)

      {
            try
            {
                int a = 10;
                int b = 2;
                int c = a / b;

                int[] arr = new int[3];
                arr[0] = 11;
                arr[1] = 22;
                arr[2] = 33;
                arr[3] = 44;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }

            //try
            //{
            //    int[] arr = new int[3];
            //    arr[0] = 11;
            //    arr[1] = 22;
            //    arr[2] = 33;
            //    arr[3] = 44;

            //    // string a = null;
            //    //  Console.WriteLine(a.Length);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("Enter a number:");
            //string number = Console.ReadLine();
            //try
            //{
            //int num = int.Parse(number);
            //Console.WriteLine("number is: " + num);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("string format is invalid!!");
            //    Console.WriteLine(ex.Message);
            //}
















            //////try
            //////{
            //////     string name = null;
            //////    Console.WriteLine(name.Length);

            //////}
            //////catch(NullReferenceException ex)
            //////{
            //////    Console.WriteLine("string is null...");
            //////    Console.WriteLine(ex.Message);
            //////}
            Console.ReadLine();
        ////    int[] a = new int[3];
        ////    try
        ////    {
        ////    a[0] = 11;
        ////    a[1] = 22;
        ////    a[2] = 33;
        ////    a[3] = 44;

        ////       foreach (int item in a)
        ////    {
        ////        Console.WriteLine(item);
        ////    }

        ////    }
        ////    catch(IndexOutOfRangeException ex)
        ////    {
        ////        Console.WriteLine("Array' range is excuded!!!");
        ////        Console.WriteLine(ex.Message);
        ////    }
        
          












            //Console.WriteLine("Enter First number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Second number:");
            //int num2 = int.Parse(Console.ReadLine());

            ////int result = num1 / num2;
            ////Console.WriteLine("Division result is:" + result);
            //try
            //{
            //    int result = num1 / num2;
            //    Console.WriteLine("Division result is:" + result);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("you cannot devide a number by zero...");
            //    Console.WriteLine(ex.Message);

            //}
            //Console.WriteLine("remaning statement 1"); 
            //Console.WriteLine("remaning statement 2");
            //Console.WriteLine("remaning statement 3");
            Console.ReadLine();

        }
    }
}
