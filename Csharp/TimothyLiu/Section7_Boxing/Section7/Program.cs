using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.Boxing box = new Test.Boxing();
            Console.WriteLine(box.obj);

            Console.ReadKey();
        }
    }
}
