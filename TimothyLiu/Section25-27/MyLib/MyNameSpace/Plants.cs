using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{
    public class Plants
    {
        public virtual void ReleaseOxygen()
        {
            Console.WriteLine("I am releasing oxygen now !");
        }
    }

    public class GreenTree : Plants
    {
        public override void ReleaseOxygen()
        {
            Console.WriteLine("GreenTree is releasing oxygen now !");
        }
    }
    public class Flowers : GreenTree
    {
        public void ReleaseOxygen() // 隐藏所派生类方法
        {
            Console.WriteLine("Flowers are obsorbing oxygen now !");
        }
    }
    public class Leaves : GreenTree
    {
        public override void ReleaseOxygen()
        {
            Console.WriteLine("Leaves are releasing oxygen now !");
        }
    }
    
}
