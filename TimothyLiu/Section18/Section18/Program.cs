using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section18
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.RefPara.Show1();
            Test.RefPara.Show2();
            Console.WriteLine("------------------------------------");
            Test.OutParaValue.Show();
            Test.OutParaRef.Show();
            Console.WriteLine("------------------------------------");
            Test.ArrParams.Show();
            Console.WriteLine("------------------------------------");
            Test.OptionalParams.Show();
            Console.WriteLine("------------------------------------");
            Test.ExtensionMethod.Show();
            Console.WriteLine("------------------------------------");
        }
    }
}
