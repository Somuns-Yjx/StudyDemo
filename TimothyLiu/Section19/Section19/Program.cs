using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section19
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.Delegate.Show();
            Console.WriteLine("------------------------------------");
            Test.Delegate2.Show();
            Console.WriteLine("------------------------------------");
            NewTest.Show();
            Console.WriteLine("------------------------------------");
            Test.ThreadTest.Show();
            Console.WriteLine("------------------------------------");
            //Test.InterFace.Show();            
            


            Console.ReadKey();
        }
    }
}
