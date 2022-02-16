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
            string given=Console.ReadLine();    
            string [] list = given.Split(',');
            List<string>list1=new List<string>();
            List<string> list2= new List<string>();
            for (int i=0;i<list.Length;i++) 
                list1.Add(list[i]);
            MergeSort mergeSort=new MergeSort();
           list2= mergeSort.Mergesort(list1);
            foreach(string s in list2)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
}
