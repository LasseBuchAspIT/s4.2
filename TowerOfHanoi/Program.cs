namespace TowerOfHanoi
{
    using TowerOfHanoi;
    internal class Program
    {
        static void Main(string[] args)
        {
            GameController gm = new(8);
            gm.GameLoop();
        }
    }
}