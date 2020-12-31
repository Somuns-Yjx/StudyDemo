using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section24
{

    public class Class
    {
        public static void Show()
        {
            var stu1 = new Student("stu1", 1);
            var stu2 = new Student("stu2", 2);
            var stu3 = new Student("stu3", 3);
            var stu4 = new Student("stu4", 4);
            var stu5 = new Student("stu5", 5);
        }

        class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public static int Amount = 0;
            public Student(string name, int id)
            {
                Amount++;
                Name = name;
                ID = id;
                Console.WriteLine(" Student " + ID + " " + Name + " adds " + " Amount = " + Amount);
            }
            ~Student()  // 析构器
            {
                Amount--;
                Console.WriteLine(" Student ID " + ID + " " + Name + " release its source " + " Amount = " + Amount);
            }
        }
    }
}
