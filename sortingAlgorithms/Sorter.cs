using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace sortingAlgorithms
{
    public static class Sorter
    {
        public static List<int> BubbleSort(List<int> inputList)
        {
            List<int> returnList = inputList;
            //repeat while not sorted
            while (!IsSorted(returnList))
            {
                //go through all elements
                for(int i = 1; i < returnList.Count; i++)
                {
                    //check if former element is bigger than next
                    if (returnList[i - 1] > returnList[i])
                    {
                        //if true swap elements
                        int tmp = returnList[i];
                        returnList[i] = returnList[i -1];
                        returnList[i - 1] = tmp;
                        
                    }
                }
            }
            return returnList;
        }

        public static List<int> InsertionSort(List<int> inputList)
        {
            List<int> returnList = inputList;
            for (int i = 1; i < returnList.Count; ++i)
            {
                int key = returnList[i];
                int j = i - 1;
        
                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && returnList[j] > key)
                {
                    returnList[j + 1] = returnList[j];
                    j = j - 1;
                }
                returnList[j + 1] = key;
            }
            return returnList;
        }
            

        public static bool IsSorted(List<int> inputList)
        {
            int previous = inputList[0];
            foreach (int value in inputList)
            {
                if (previous > value)
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
