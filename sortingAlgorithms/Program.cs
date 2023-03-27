using System.Diagnostics;

namespace sortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            List<int> testArr = new();

            for (int i = 0; i < 1000; i++)
            {
                testArr.Add(rnd.Next(10000));
            }

            //output test array
            foreach(int value in testArr)
            {
                Console.Write(value + ", ");
            }


            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //Sorter.BubbleSort(testArr);
            //stopwatch.Stop();


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Sorter.InsertionSort(testArr);
            stopwatch.Stop();



            //output test array again to see if sorting worked
            Console.WriteLine("\n sorted array: \n");
            Console.WriteLine("stopwatch time: " + stopwatch.Elapsed);
            foreach (int value in testArr)
            {
                Console.Write(value + ", ");
            }

            


        }
    }
}