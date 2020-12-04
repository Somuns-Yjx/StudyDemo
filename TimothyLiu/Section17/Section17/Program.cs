using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section17
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.StaticField.Show();
            Test.Property.Show();
            Test.Indexer.Show();
            Test.Constant.Show();
        }
    }
}
