using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pushToExt
{
    public static class pushToExtClass
    {
        public static void Main(string[] args)
        {
            test();
            
        }

        public static void test()
        {
            string[] lines = { "First line", "Second line", "Third line" };
            System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);
            Console.WriteLine("test");
            Console.ReadKey();
        }
    }
}
