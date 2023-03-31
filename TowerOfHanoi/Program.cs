namespace TowerOfHanoi
{
    using TowerOfHanoi;
    internal class Program
    {
        static void Main(string[] args)
        {
            GameController gm = new(5);
            gm.GameLoop();
        }
    }
}