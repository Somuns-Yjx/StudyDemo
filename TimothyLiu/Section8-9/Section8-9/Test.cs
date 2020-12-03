using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8
{
    public class Test
    {

        // 代码复用 
        // 变量名有意义：不直接使用3.14
        public class Reuse
        {
            public double GetCircleArea(double r)
            {
                return Math.PI * r * r;
            }
            public double GetCylinderVolume(double r, double h)
            {
                return GetCircleArea(r) * h;
            }
            public double GetConeVolume(double r, double h)
            {
                return GetCylinderVolume(r, h) / 3;
            }
        }

        // 静态方法
        public class Function
        {
            public static double GetPi()
            {
                return Math.PI;
            }
        }

        // 构造器
        public class Student
        {
            public Student(int initId, string initSentence)
            {
                this.id = initId;
                this.sentence = initSentence;
            }
            public int id;
            public string sentence;
        }


        // 重载
        public class OverLoad
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Add(ref int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
        }

        // 测试：方法存放于栈中，当方法无限递归，则栈溢出
        public class CallBack       
        {
            public static int times = 0;
            public static void Recursion()
            {
                times++;
                if (times != 15070)  // 15071则栈溢出
                    Recursion();
                else
                    return;
            }

        }



    }
}
