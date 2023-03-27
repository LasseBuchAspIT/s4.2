using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class SortedArray
    {
        public List<int> arr;



        //constructors
        public SortedArray(List<int> arr)
        {
            if (IsSorted(arr))
            {
                this.arr = arr;
            }
            else
            {
                arr.Sort();
                this.arr = arr;
            }
        }

        //simplified method for easier access
        public int BinarySearch(int target)
        {
            return BinarySearchRecu(target, this.arr, 0, this.arr.Count);
        }

        //actual math
        private int BinarySearchRecu(int target, List<int> arr, int min, int max)
        {
            //console writelines to catch my fuckups
            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
            Console.WriteLine("search: " + (max - (max - min) / 2));

            //gets mid between min and max and checks if its the target number in the array
            if (arr[max - ((max - min) / 2) - 1] == target)
            {
                return max - (max - min) / 2;
            }
            else if (min != max)
            {
                //target is in lower half
                if (arr[max - ((max - min) / 2) - 1] > target)
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
            //returns -1 if number not in array
            return -1;


        }
        public void InsertToSorted(int numberToInsert)
        {
            //loop throuh every index of the list to find a number bigger than the number to insert
            for(int i = 0; i < arr.Count; i++)
            {
                //inserts at index just before higher value
                if(arr[i] > numberToInsert)
                {
                    arr.Insert(i, numberToInsert);
                    return;
                }
            }

            //inserts at last index if no higher number found (number to insert must be highest)
            arr.Add(numberToInsert);
            return;

        }

        //linear search
        public bool IsSorted(List<int> inputList)
        {
            int previous = inputList[0];
            foreach(int value in inputList)
            {
                if(previous > value)
                {
                    return false;
                }
                else
                {
                    previous = value;
                }
            }
            return true;
        }
    }
}
