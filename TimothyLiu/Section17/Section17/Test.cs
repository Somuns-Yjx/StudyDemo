using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section17
{
    class Test
    {
        // 静态字段
        public class StaticField
        {
            public static void Show()
            {
                Console.WriteLine("-----------------静态字段------------------");
                List<Student> stu = new List<Student>();
                for (int i = 0; i < 100; i++)
                {
                    stu.Add(new Student());
                }
                Console.WriteLine(Student.Amount);
                Console.WriteLine("-------------------------------------------");
            }
            class Student
            {
                public static int Amount;

                public Student()
                {
                    Student.Amount++;
                }
            }
        }
        // 属性
        public class Property
        {
            public static void Show()
            {
                try
                {
                    Console.WriteLine("-------------------属性--------------------");
                    Student stu1 = new Student();
                    stu1.Age = 20;
                    Student stu2 = new Student();
                    stu2.Age = 20;
                    Student stu3 = new Student();
                    stu3.Age = 150;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("-------------------------------------------");
                }
            }
            class Student
            {
                private int my_Age;
                public int Age
                {
                    set
                    {
                        if (value >= 0 && value <= 120)
                        { my_Age = value; }
                        else
                        {
                            throw new Exception("Age Error");
                        }
                    }
                    get { return my_Age; }
                }
            }
        }
        // 索引器
        public class Indexer
        {
            public static void Show()
            {
                Student stu = new Student();
                var score = stu["math"];
                Console.WriteLine(score);
                stu["math"] = 150;
                score = stu["math"];
                Console.WriteLine(score);
            }
            class Student
            {
                private Dictionary<string, int> scoreDictionary = new Dictionary<string, int> { };
                public int? this[string subject]
                {
                    get
                    {
                        if (scoreDictionary.ContainsKey(subject))
                        {
                            return scoreDictionary[subject];
                        }
                        else
                            return null;
                    }
                    set
                    {
                        if (value.HasValue == false)
                        {
                            throw new Exception("Set Error");
                        }
                        if (scoreDictionary.ContainsKey(subject))
                        {
                            scoreDictionary[subject] = value.Value;
                        }
                        else
                            scoreDictionary.Add(subject, value.Value);
                    }
                }
            }
        }
        // 常量
        public class Constant
        {
            public static void Show()
            {
                System.Diagnostics.Process.Start(Url.SoutheastUniversityUrl);
                
            }
            class Url
            {
                public  const string SoutheastUniversityUrl = "https://cse.seu.edu.cn/xlsszs/list.htm";
            }
        }
        



    }
}
