using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class SortedArray
    {
        int[] arr;


        //constructors
        public SortedArray(int[] arr)
        {
            this.arr = arr;
        }

        public int BinarySearch(int target)
        {
            return BinarySearchRecu(target, this.arr, 0, this.arr.Length);
        }

        //actual math
        private int BinarySearchRecu(int target, int[] arr, int min, int max)
        {
            //console writelines to catch my fuckups
            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
            Console.WriteLine("search: " + (max - (max - min) / 2));

            //gets mid between min and max and checks if its the target number in the array
            if (arr[max - ((max - min) / 2)] == target)
            {
                return max - (max - min) / 2;
            }
            else if (min != max)
            {
                //target is in lower half
                if (arr[max - ((max - min) / 2)] > target)
                {
                    max = max - (max - min) / 2;
                    return BinarySearchRecu(target, arr, min, max);
                }
                //target in upper half
                else
                {
                    min = max - ((max - min) / 2);
                    return BinarySearchRecu(target, arr, min, max);
                }
            }
            //returns 0 if number not in array
            return 0;

        }
    }
}
