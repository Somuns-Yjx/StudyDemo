using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{
    public class Function
    {
        public static T[] Zip<T>(T[] a, T[] b)
        {
            int ai = 0;
            int bi = 0;
            int zi = 0;
            T[] Zipped = new T[a.Length + b.Length];
            do
            {
                if (ai < a.Length) Zipped[zi++] = a[ai++];
                if (bi < b.Length) Zipped[zi++] = b[bi++];
            } while (zi != a.Length + b.Length);
            return Zipped;
        }

        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Mul(double a, double b)
        {
            Console.WriteLine(a * b);
        }
    }

}
