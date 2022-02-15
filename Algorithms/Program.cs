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
           BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(ref list);
            for (int i = 0; i < list.Length; i++) Console.Write(list[i] + " ");
        }
    }
}
