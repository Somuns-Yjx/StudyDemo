using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section10_11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Section10
            Console.WriteLine("=========Section10=======" + "\n");
            #region Operator
            Test.Person person1 = new Test.Person();
            Test.Person person2 = new Test.Person();
            person1.Name = "Husband";
            person2.Name = "Wife";
            List<Test.Person> people = person1 + person2;
            foreach (var p in people)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine("=========================" + "\n");
            #endregion

            #region 委托
            Test.ActionTest.myAction();
            Console.WriteLine("=========================" + "\n");
            #endregion

            #region 元素访问操作符[]
            Test.Brackets brackets = new Test.Brackets();
            brackets.InitDic();
            Console.WriteLine("=========================" + "\n");
            #endregion

            #region 操作符Default
            Test.Enum.ConsoleDefault();     // 尽管low为enum的首项，但默认值被改为1，所以default不为low而为0
            Console.WriteLine("=========================" + "\n");
            #endregion
            #endregion

            #region Section11
            Console.WriteLine("=========Section11=======" + "\n");

            #region New操作符
            Test.New n = new Test.New();
            n.Show1();
            n.Show2();
            Console.WriteLine("=========================" + "\n");
            #endregion

            #region 匿名类型
            n.Show3();
            Console.WriteLine("=========================" + "\n");
            #endregion

            #region 取地址（不安全代码）
            Test.ObtainAddr.Show();
            Console.WriteLine("=========================" + "\n");
            #endregion

            #endregion

            #region Section12
            Console.WriteLine("=========Section12=======" + "\n");

            #region 子类父类隐式转换
            Test.ImplictConvert.Teacher t = new Test.ImplictConvert.Teacher();
            // t. 下有eat、think、teach方法
            Test.ImplictConvert.Human h = t;
            // h.下有eat、think方法
            Test.ImplictConvert.Animal a = t;
            // a.下只有eat方法

            #endregion

            #region 自定义类型显式转换
            Test.ExplicitConvert.RunExample();
            Console.WriteLine("=========================" + "\n");

            #endregion

            #region ?? Null值合并
            Test.NullableType.Show();
            Console.WriteLine("=========================" + "\n");
            #endregion

            #region 条件操作符
            Test.Condition.Show();
            Console.WriteLine("=========================" + "\n");
            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
