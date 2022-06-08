using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            libraryM obj = new libraryM();
            //string a = obj.Book();
            //Console.WriteLine(a);
            string b = obj.aurthor();
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
