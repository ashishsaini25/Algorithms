using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MergeSort
    {
        public List<string> Mergesort(List<string> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<string> left = new List<string>();
            List<string> right = new List<string>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = Mergesort(left);
            right = Mergesort(right);
            return Merge(left, right);
        }

        public List<string> Merge(List<string> left, List<string> right)
        {
            List<string> result = new List<string>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First().CompareTo( right.First())<=0)  
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
