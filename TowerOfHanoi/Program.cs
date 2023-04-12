namespace TowerOfHanoi
{
    using TowerOfHanoi;
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();

            GameController gm = new(rnd.Next(1, 10));
            gm.GameLoop();
        }
    }
}