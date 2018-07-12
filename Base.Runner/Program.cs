using System.Diagnostics;

namespace Base.Runner
{
    class Program
    {
        public static void Main(string[] args)
        {
            new Search.LinearSearch(true).Search();


            System.Console.WriteLine("\n\nPress any key to exit...");
            System.Console.ReadKey();
        }
    }
}
