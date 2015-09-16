using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextPrimeNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("----- Find Next Prime Number ------");
            Console.WriteLine();
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            double parsedinput = double.Parse(input);
            double number = parsedinput;
            while (true)
            {
                bool isPrime = true;
                number += 1;
                double squarenumber = Math.Sqrt(parsedinput);
                for (int i = 2; i <= squarenumber; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("The next prime number after {0} is {1}.", parsedinput, number);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
