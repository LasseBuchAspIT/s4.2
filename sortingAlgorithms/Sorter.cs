using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingAlgorithms
{
    public static class Sorter
    {
        public static List<int> BubbleSort(List<int> inputList)
        {
            //repeat while not sorted
            while (!IsSorted(inputList))
            {
                //go through all elements
                for(int i = 1; i < inputList.Count; i++)
                {
                    //check if former element is bigger than next
                    if (inputList[i - 1] > inputList[i])
                    {
                        //if true swap elements
                        int tmp = inputList[i];
                        inputList[i] = inputList[i -1];
                        inputList[i - 1] = tmp;

                    }
                }
            }
            return inputList;
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
