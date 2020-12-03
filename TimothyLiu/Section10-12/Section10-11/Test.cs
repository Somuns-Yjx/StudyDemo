using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section10_11
{
    class Test
    {
        #region Section10
        // 操作符
        public class Person
        {
            public string Name;          /*     △△△     */
            public static List<Person> operator +(Person p1, Person p2) // GetMarried(Person p1, Person p2)  
            {
                List<Person> p = new List<Person> { };
                p.Add(p1);
                p.Add(p2);
                for (int i = 0; i < 11; i++)
                {
                    Person child = new Person();
                    child.Name = p1.Name + "&" + p2.Name + "'s child";
                    p.Add(child);
                }
                return p;
            }
        }

        // 点（.）操作符：访问成员
        public class Dot
        {
            public static Form myForm = new Form();
        }

        // 委托
        public class ActionTest
        {
            public static Action myAction = new Action(Test.ActionTest.PrintHelloWorld);
            public static void PrintHelloWorld()
            {
                Console.WriteLine("Hello World");
            }
        }

        // 元素访问操作符[]
        public class Brackets
        {
            Dictionary<string, Student> stu = new Dictionary<string, Student> { };

            public void InitDic()
            {
                for (int index = 1; index <= 100; index++)
                {
                    Student s = new Student();
                    s.name = "s" + index.ToString();
                    s.score = 100 + index;
                    stu.Add(s.name, s);
                }
                Student number50 = stu["s50"];
                Console.WriteLine(number50.score);
            }

            class Student
            {
                public string name;
                public int score;
            }
        }

        // 运算符default 对于枚举类型
        public class Enum
        {
            public static void ConsoleDefault()
            {
                Level lv = default(Level);
                Console.WriteLine(lv);
            }
            public enum Level
            {
                low = 1,
                mid = 2,
                high = 3
            }

        }
        #endregion

        #region Section11

        // 操作符new 实例构造器 与 初始化器
        public class New
        {
            public void Show1()
            {
                Form myForm = new Form() { Text = "Hello World" };
                myForm.ShowDialog();
            }
            public void Show2()  // 无对象类型
            {
                new Form() { Text = "Hello", FormBorderStyle = FormBorderStyle.SizableToolWindow }.ShowDialog();
            }

            public void Show3()  // 匿名类型
            {
                var person = new { Name = "夏东南", Age = 24 };
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.GetType().Name);
            }
        }

        // 取地址操作符（不可对string类型）
        public class ObtainAddr
        {
            public static void Show()
            {
                unsafe
                {
                    Student stu;
                    stu.Id = 1;
                    stu.score = 390;
                    Student* s = &stu;
                    s->score = 400;
                    Console.WriteLine(stu.score);
                }
            }
            struct Student
            {
                public int score;
                public int Id;
            }
        }


        #endregion

        #region Section12

        #region 子类向父类的隐式转换
        public class ImplictConvert
        {
            public class Animal
            {
                public void Eat()
                {
                    Console.WriteLine("Eating...");
                }
            }
            public class Human : Animal // 继承Animal类
            {
                public void Think()
                {
                    Console.WriteLine("Thinking...");
                }
            }
            public class Teacher : Human // 继承Human类
            {
                public void Teach()
                {
                    Console.WriteLine("Teaching");
                }
            }
        }

        #endregion

        #region 自定义显式类型转换

        public class ExplicitConvert
        {
            public class Monkey
            {
                public int age;
            }
            public class Stone
            {
                public int age;

                public static explicit operator Monkey(Stone stone)
                {
                    Monkey m = new Monkey();
                    m.age = stone.age / 500;
                    return m;
                }
            }

            public static void RunExample()
            {
                Stone s = new Stone();
                s.age = 5000;
                Monkey m = (Monkey)s;
                Console.WriteLine(m.age);
            }
        }

        #endregion

        #region ?? Null值合并
        public class NullableType
        {
            public static void Show()
            {
                Nullable<int> score = null;         // int ? score = null 与左边表达式相等
                Console.WriteLine(score.ToString());    // score = score ?? 1; 如果score为null，则赋1
                score = 150;
                Console.WriteLine(score.ToString());
            }
        }
        #endregion

        #region 条件操作符
        public class Condition
        {
            public static void Show()
            {
                int x = 1;
                bool res = (x == 1) ? true : false;
                Console.WriteLine(res.ToString());
            }
        }
        #endregion

        #endregion
    }
}
