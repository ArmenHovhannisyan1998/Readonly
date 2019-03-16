using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly
{
    class Program
    {
        public readonly string field = "Hello ";

        public Program()
        {
            field = "Real magic";
            field += "!";
        }

        static void Main(string[] args)
        {
            Program instance = new Program();

            Console.WriteLine(instance.field);

            Console.ReadKey();
        }
    }
}
