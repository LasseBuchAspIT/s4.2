using System.Net.NetworkInformation;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create random sorted array for testing
            Random rnd = new();
            int[] sortedArr = new int[100];

            for(int i = 0; i < 100; i++)
            {
                sortedArr[i] = rnd.Next(1, 100);
            }
            Array.Sort(sortedArr);


            //array for easy testing
            // int[] testArr = new int[100] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100};

            //write method result
            Console.WriteLine(BinarySearch(99, sortedArr));

            //medthod for ease of use for users
            int BinarySearch(int target, int[] arr)
            {
                    return BinarySearchRecu(target, arr, 0, arr.Length);
            }

            //actual math
            int BinarySearchRecu(int target, int[] arr, int min, int max)
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
                else if(min != max)
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
}