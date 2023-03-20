namespace FolderMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirSearch("C:\\Users\\lass132d\\Desktop\\V");

            void DirSearch(string sDir)
            {

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    Console.WriteLine("Folder: " + d + "\n");
                    foreach (string f in Directory.GetFiles(sDir))
                    {
                        Console.WriteLine(f);
                    }
                    DirSearch(d);
                }

            }
        }
    }
}