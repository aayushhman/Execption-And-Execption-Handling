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
            Console.WriteLine("Enter First number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second number:");
            int num2 = int.Parse(Console.ReadLine());

            //int result = num1 / num2;
            //Console.WriteLine("Division result is:" + result);
            try
            {
                int result = num1 / num2;
                Console.WriteLine("Division result is:" + result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("you cannot devide a number by zero...");
                Console.WriteLine(ex.Message);

            }
            Console.WriteLine("remaning statement 1"); 
            Console.WriteLine("remaning statement 2");
            Console.WriteLine("remaning statement 3");
            Console.ReadLine();

        }
    }
}
