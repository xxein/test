using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().DoPrint();
        }

        public void DoPrint()
        {
            Console.WriteLine("Boo");
            Console.WriteLine("Foo");
            Console.WriteLine("Bar");
        }
    }
}
