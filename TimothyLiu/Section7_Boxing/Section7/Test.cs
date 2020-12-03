using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section7
{
    public class Test
    {
        /// <summary>
        /// 装箱
        /// </summary>
        public class Boxing
        {
            public static int x = 200; // 栈上为x分配空间并存100的二进制
            public Object obj = x;     // 1：对于object这种引用类型，会先在栈为obj分配4字节空间
                                         // 2：后在堆上将x实例化
            // 最后一步是赋值  但是对于此类，obj最终存放的是x的地址
        }
    }
}
