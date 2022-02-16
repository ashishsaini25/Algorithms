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
            Console.WriteLine("Enter the two string");
            string first,second;
            first = Console.ReadLine();
            second = Console.ReadLine();
            Anagram anagram = new Anagram();
            if (anagram.Check(first, second))
            {
                Console.WriteLine("Given string are anagram");
            }
            else
            {
                Console.WriteLine("Strings are not anagram");
            }
        }
    }
}
