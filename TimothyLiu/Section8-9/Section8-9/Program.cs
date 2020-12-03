using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            // reuse
            Test.Reuse reuse = new Test.Reuse();
            Console.WriteLine(reuse.GetCircleArea(10));
            Console.WriteLine(reuse.GetCylinderVolume(10, 5));
            Console.WriteLine(reuse.GetConeVolume(10, 5));
            Console.WriteLine("============================");
            
            // static 
            Console.WriteLine(Test.Function.GetPi());
            Console.WriteLine("============================");
            
            // Constructor
            Test.Student stu = new Test.Student(1,"我曾踏足山巅，也曾跌落低谷");  // 实例化时需要初始化
            Console.WriteLine(stu.id);
            Console.WriteLine(stu.sentence);
            Console.WriteLine("二者都使我受益良多");
            Console.WriteLine("============================");
            
            // OverLoad
            Test.OverLoad ol = new Test.OverLoad();
            Console.WriteLine(ol.Add(10, 30));
            Console.WriteLine("============================");

            // Stack Recursion
            Test.CallBack.Recursion();

            Console.ReadKey();
        }
    }
}
