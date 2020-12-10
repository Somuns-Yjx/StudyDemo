using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section23
{
    delegate double MyDele(double a, double b);  // 一般委托
    delegate T MyGenericDele<T>(T a, T b);            // 泛型委托

    class NormalDele
    {
        public static void Show()
        {
            MyDele myDele = new MyDele(Add);
            double res = myDele(1, 2);
            Console.WriteLine(res);
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
    }
    class GenericDele
    {
        public static void Show()
        {
            MyGenericDele<double> dele1 = new MyGenericDele<double>(Mul);
            Console.WriteLine(dele1(5, 20));
            MyGenericDele<int> dele2 = new MyGenericDele<int>(Sub);
            Console.WriteLine(dele2(10, 20));

        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
    class LambdaDele
    {
        public static void Show()
        {
            Console.WriteLine(func1(100, 200));
            Console.WriteLine(func2(100, 200));
        }
        static Func<int, int, int> func1 = new Func<int, int, int>((int a, int b) => { return a + b; });
        static Func<int, int, int> func2 = (a, b) => { return a - b; };
    }
    class GenericDele2
    {
        public static void Show()
        {
            DoSomeCalc((a, b) => { return a * b; }, 100, 200);
        }
        static void DoSomeCalc<T>(Func<T, T, T> func, T x, T y)
        {
            T res = func(x, y);
            Console.WriteLine(res);
        }
    }
    class LinqTest
    {
        // 暂无
    } 
}
