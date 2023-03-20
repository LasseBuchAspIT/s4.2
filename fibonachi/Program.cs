using System.Xml.Schema;

namespace fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FibRecuFirstNth(27);

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
            int FibIter(int number)
            {
                Console.WriteLine(0);
                long current = 1;
                long last = 0;
                long temp;
                for (int i = 2; i < number; i++)
                {
                    Console.WriteLine(current);
                    temp = current;
                    current += last;
                    last = temp;
                }

                return Convert.ToInt32(current);
            }
        }
    }
}