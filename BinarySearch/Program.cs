using System.Diagnostics;
using System.Net.NetworkInformation;


namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //create random sorted array for testing
            Random rnd = new();
            List<int> sortedArr = new();

            for(int i = 0; i < 10000000; i++)
            {
                sortedArr.Add(rnd.Next(100000000));
            }


            Random rnd2 = new();
            int numberTofind = rnd.Next(100000000);

            Console.WriteLine(numberTofind);
            

            if (!sortedArr.Contains(numberTofind))
            {
                sortedArr.Add(numberTofind);
            }

            //sort array
            sortedArr.Sort();

            SortedArray arr = new SortedArray(sortedArr);

            


            Stopwatch linearWatch = Stopwatch.StartNew();
            Console.WriteLine(arr.LinearSearch(numberTofind));
            linearWatch.Stop();
            Console.WriteLine("linear search time: " + linearWatch.Elapsed);

            Stopwatch binaryRecuWatch = Stopwatch.StartNew();
            Console.WriteLine(arr.BinarySearchRecuSimp(numberTofind));
            binaryRecuWatch.Stop();
            Console.WriteLine("binaryRecu search time: " + binaryRecuWatch.Elapsed);



            Stopwatch binaryIterWatch = Stopwatch.StartNew();
            Console.WriteLine(arr.BinarySearchIter(numberTofind));
            binaryIterWatch.Stop();
            Console.WriteLine("binaryIter search time: " + binaryIterWatch.Elapsed);


            ////array for easy testing
            //List<int> testArr = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100};

            //SortedArray testArr2 = new SortedArray(testArr);




        }
    }
}