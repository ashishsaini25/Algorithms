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
            Console.WriteLine("Enter the List of Words Seperated By ','");
            BinarySearch binarySearch = new BinarySearch();
            string given=Console.ReadLine();    
            string [] list = given.Split(',');
            List<string> list2 = new List<string>();
            foreach(string item in list)
            {
                list2.Add(item);
            }
            list2.Sort();
            int i = 0;
            foreach(string item in list2)
            {
                list[i] = item;
                i++;
            }
            Console.WriteLine("Enter the string to search");
            string find=Console.ReadLine();
            int position = binarySearch.Search(list, find, 0, list.Length - 1);
            if (position!=-1)
            {
                Console.WriteLine("Element is present at index: "+position);
            }
            else
            {
                Console.WriteLine("Element is not present");
            }
        }
    }
}
