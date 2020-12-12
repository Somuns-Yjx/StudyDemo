using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.MyNameSpace;
namespace Section25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(1, 2));
            Console.WriteLine("-----------------------------------------------");
            Derive.Show();
            Console.WriteLine("-----------------------------------------------");
            Tiger t1 = new Tiger("tiger", 2);
            Squirrel s1 = new Squirrel("squirrel", 3);
            Console.WriteLine("-----------------------------------------------");
            Plants p = new Plants();
            GreenTree gt = new GreenTree();
            Plants l = new Leaves();        // 可以左边 但是不可以 Leaves l = new Plants();
            Flowers f = new Flowers();   // 直接调用方法，并不会出现源方法
            p.ReleaseOxygen();
            gt.ReleaseOxygen();
            l.ReleaseOxygen();
            f.ReleaseOxygen();
        }
    }
}
