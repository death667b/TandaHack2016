using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pushToExt
{
    static class pushToExtClass
    {
        static void Main(string[] args)
        {
            test();
            
        }

        static void test()
        {
            string[] lines = { "First line", "Second line", "Third line" };
            System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);
            Console.WriteLine("test");
            Console.ReadKey();
        }
    }
}
