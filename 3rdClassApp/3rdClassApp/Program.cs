using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            var num2 = int.Parse(Console.ReadLine());

            int total = num1 + num2;
            int total1 = num1 - num2;
            int total2 = num1 * num2;
            int total3 = num1 / num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, total);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, total1);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, total2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, total3);


            Console.ReadLine();
        }
    }
}
