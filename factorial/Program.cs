namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(ToFactorialRecu(5));

            //iterative

            int ToFactorialRecu(int number)
            {
                if (number > 1)
                {
                    return number *= ToFactorialRecu(number - 1);
                }
                return number;
            }
        }
    }
}