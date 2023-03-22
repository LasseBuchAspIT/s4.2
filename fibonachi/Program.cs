using System.Xml.Schema;

namespace fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            FibRecuFirstNth(45);
            watch.Stop();
            Console.WriteLine("FibRecu: " + watch.Elapsed);

            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            FibIter(45);
            watch2.Stop();
            Console.WriteLine("FibIter: " + watch2.Elapsed);


            // opg 1
            //recursive fib(extremely inefficient implimentation)
            int FibRecu(int number)
            {
                if (number < 2) return number;

                return FibRecu(number - 1) + FibRecu(number - 2);
            }
            

            //opg 2
            void FibRecuFirstNth(int number)
            {
                for(int i = 0; i < number; i++)
                {
                    Console.WriteLine(FibRecu(i));
                }
            }

            //iterative fib
            long FibIter(int number)
            {
                Console.WriteLine(0);
                long current = 1;
                long last = 0;
                long temp;
                for (int i = 1; i < number; i++)
                {
                    Console.WriteLine(current);
                    temp = current;
                    current += last;
                    last = temp;
                }

                return current;
            }
        }
    }
}