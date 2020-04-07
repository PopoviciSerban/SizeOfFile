using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SizeOfFileOrFolder
{
    class Program
    {
        static void Main()
        {
            string fileName = @"C:\Users\Serban\Documents\smk.txt";

            FileInfo f = new FileInfo(fileName);

            Console.WriteLine("The size of {0} is {1} bytes.", f.Name, f.Length);

            Console.ReadKey();
        }
    }
}
