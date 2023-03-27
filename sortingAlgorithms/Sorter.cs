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

        public static List<int> InsertionSort(List<int> inputList)
        {

            for(int i = 1; i < inputList.Count; i++)
            {
                if (inputList[i] < inputList[i - 1])
                {
                    int tmpInt = i;
                    while (inputList[tmpInt] < inputList[tmpInt - 1] && tmpInt > 0)
                    {
                        int tmp = inputList[i];
                        inputList[i] = inputList[i - 1];
                        inputList[i - 1] = tmp;
                    }
                }
            }

            return new List<int>();
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
