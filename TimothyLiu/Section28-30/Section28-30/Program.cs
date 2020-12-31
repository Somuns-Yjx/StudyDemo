using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.MyNameSpace;
using System.Collections;
using System.Reflection;
namespace Section28_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Section28---------------------");
            Bird bd = new Bird();
            Monkey mk = new Monkey();
            Human hm = new Human();
            bd.Eat();
            bd.Fly();
            mk.Eat();
            hm.MakeDishes();
            hm.Eat();
            Console.WriteLine("---------------------------------------------------");
            Pilot p = new Pilot();
            p.Fly();
            p.Accelerate();
            p.SlowDown();

            Console.WriteLine("---------------------Section29---------------------");
            var pu1 = new PhoneUser(new NokiaPhone());
            pu1.UsePhone();
            Console.WriteLine("---------------------------------------------------");
            var pu2 = new PhoneUser(new Huawei());
            pu2.UsePhone();
            Console.WriteLine("---------------------------------------------------");
            var df = new DeskFan(new PowerSuply());
            Console.WriteLine(df.Work());
            Console.WriteLine("---------------------Section30A--------------------");
            #region 接口隔离1
            var gt = new GreenPlants();
            gt.AbsorbOxygen();
            gt.Photosynthesize();
            Rose r = new Rose();
            r.AbsorbOxygen();
            #endregion
            Console.WriteLine("---------------------------------------------------");
            #region 接口隔离2
            int[] nums1 = { 1, 2, 3, 4, 5 };
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };
            var nums3 = new ReadOnlyCollection(nums1);
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Sum(nums2));
            Console.WriteLine(Sum(nums3));
            #endregion

            #region 接口隔离3
            var pp = new People();
            pp.Warm();
            var ppp = pp as IRogue; // var ppp = (IRogue)pp;
            ppp.Bully();
            #endregion

            Console.WriteLine("---------------------Section30B--------------------");
            IMetal mt = new Aurum();
            Type t = mt.GetType();
            object o = Activator.CreateInstance(t);
            MethodInfo oxidize = t.GetMethod("Oxidize");
            MethodInfo sold = t.GetMethod("Sold");
            oxidize.Invoke(o, null);
            oxidize.Invoke(o, null);

            Console.Read();

        }

        static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }
            return sum;
        }
    }

}
