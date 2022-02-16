using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public  class Anagram
    {
        static string SortString(String str)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string ans="";
            for (int i = 0; i < arr.Length; i++)
                ans += arr[i];
            return ans;
            
        }
        public bool Check(string first,string second)
        {
            first.ToLower();
            second.ToLower();
            first=SortString(first);
            second=SortString(second);
            Console.WriteLine(first,second);    
            if (first.CompareTo(second) == 0)
            {
                return true;
            }
            else
                return false;

        }
    }
}
