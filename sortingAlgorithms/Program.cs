using System.Diagnostics;

namespace sortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            List<int> testArr = new();

            for (int i = 0; i < 100000; i++)
            {
                testArr.Add(rnd.Next(100000));
            }


            


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<int> bubbleList = Sorter.InsertionSort(new List<int>(testArr));
            stopwatch.Stop();




            //insertion sort test
            //output test array again to see if sorting worked
            Console.WriteLine("\n sorted array: \n");
            Console.WriteLine("bubblesort stopwatch time: " + stopwatch.Elapsed);




            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            List<int> inseertionList = Sorter.BubbleSort(new List<int>(testArr));
            stopwatch2.Stop();

            //bubble sort test
            //output test array again to see if sorting worked
            Console.WriteLine("\n sorted array: \n");
            Console.WriteLine("Insertion stopwatch time: " + stopwatch2.Elapsed);


        }
    }
}