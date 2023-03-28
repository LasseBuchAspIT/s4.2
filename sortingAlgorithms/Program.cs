using System.Diagnostics;
using System.Transactions;

namespace sortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            List<int> testArr = new();

            for (int i = 0; i < 600000; i++)
            {
                testArr.Add(rnd.Next(1000000));
            }


            


            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //List<int> bubbleList = Sorter.InsertionSort(new List<int>(testArr));
            //stopwatch.Stop();




            ////insertion sort test
            ////output test array again to see if sorting worked
            //Console.WriteLine("\n sorted array: \n");
            //Console.WriteLine("bubblesort stopwatch time: " + stopwatch.Elapsed);




            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            List<int> inseertionList = Sorter.BubbleSort(new List<int>(testArr));
            stopwatch2.Stop();

            foreach(int value in inseertionList)
            {
                Console.WriteLine(value);
            }

            //bubble sort test
            //output test array again to see if sorting worked
            Console.WriteLine("\n sorted array: \n");
            Console.WriteLine("Insertion stopwatch time: " + stopwatch2.Elapsed);


        }
    }
}