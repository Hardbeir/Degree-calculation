using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Degree_calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; float a, x, wynik = 0; bool succ;
            Console.WriteLine("A program that calculates the value of a polynomial of any degree > 1");
            do
            {

                Console.Write("Enter the degree of the polynomial: ");
                succ = int.TryParse(Console.ReadLine(), out n);
                if (!succ) Console.WriteLine("Invalid number format.");
                else
                    if (n < 2) Console.WriteLine("The degree of the polynomial must be at least 2.");
            } while (!succ || n <2);

            do
            {

                Console.Write("Give X ");
                succ = float.TryParse(Console.ReadLine(), out x);
                if (!succ) Console.WriteLine("Invalid number format.");
            } while (!succ);

            for (int i = n; i >= 0; i--)
            {
                do
                {

                    Console.Write("Give a" + i + ": ");
                    succ = float.TryParse(Console.ReadLine(), out a);
                    if (!succ) Console.WriteLine("Invalid number format.");
                } while (!succ);
                wynik = wynik * x + a;
                Console.WriteLine("Partial result = " + wynik);
            }
            Console.WriteLine("Final result = {0}", wynik);

                Console.ReadKey();
            
  
        }
    }
}
