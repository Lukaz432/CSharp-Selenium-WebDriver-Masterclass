using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            //escape sequence by:
            // 1. double \\
            // 2. @ sign at the front @"C:\my documents\homedirectory\files"
            string file = "C:\\my documents\\homedirectory\\files";
            Console.WriteLine(file);
        }
    }
}
