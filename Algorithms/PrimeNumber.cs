using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public  class PrimeNumber
    {
        public bool PrimeCheck(int n)
        {
            if(n==0||n==1) return false;
            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
         public void PrintPrime(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                if (PrimeCheck(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
