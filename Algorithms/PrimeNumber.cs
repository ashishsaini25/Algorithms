using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public  class PrimeNumber
    {
        public List<int> Anangram =new List<int>();
         public bool Pallindrome(string s)
        {
            string curr = "";
            for (int i = s.Length - 1; i >= 0; i--)
                curr += s[i];
            if (s.CompareTo(curr) == 0) return true;
            else
                return false;
        }
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
            Console.Write("The Pallindromic Prime no are :");   
            for(int i = 0; i <= n; i++)
            {
                if (PrimeCheck(i))
                {
                    if (Pallindrome(Convert.ToString(i))){
                       Console.Write(i+" ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
