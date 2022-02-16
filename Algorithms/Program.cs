using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number upto which you want prime number");
            int number=Convert.ToInt32(Console.ReadLine());
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.PrintPrime(number);
        }
    }
}
