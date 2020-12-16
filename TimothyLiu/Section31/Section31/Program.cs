using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.MyNameSpace;

namespace Section31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-------------------Version 1.0 ----------------------*/
            Console.WriteLine("------------------------------------------------------");
            Apple ap1 = new Apple() { Color = "Red" };
            Book bk1 = new Book() { Name = "New Book" };
            //Box bx1 = new Box() { Apple = ap1 };
            //Box bx2 = new Box() { Book = bk1 };

            /*-------------------Version 1.1 ----------------------*/
            Box bx1 = new Box() { Cargo = ap1 };
            Box bx2 = new Box() { Cargo = bk1 };
            if (bx1.Cargo as Apple != null)
                Console.WriteLine((bx1.Cargo as Apple).Color);
            if (bx2.Cargo as Apple != null)
                Console.WriteLine((bx2.Cargo as Apple).Color);

            Console.WriteLine("------------------- Version 1.2 ----------------------");
            Apple apple = new Apple() { Color = "Green" };
            Book book = new Book() { Name = "计算机科学与技术" };
            NewBox<Apple> box1 = new NewBox<Apple>() { Cargo = apple };
            NewBox<Book> box2 = new NewBox<Book>() { Cargo = book };
            Console.WriteLine(box1.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);

            Console.WriteLine("------------------- Generic Interface ----------------");
            Student<int> student = new Student<int> { };
            student.ID = 100000;
            student.Name = "Southeast Autumn";
            Console.WriteLine(student.ID + " " + student.Name);
            Student2 stu2 = new Student2();
            stu2.ID = 1000000000000001;
            stu2.Name = "Southeast Autumn";
            Console.WriteLine(stu2.ID + " " + stu2.Name);

            Console.WriteLine("------------------- Generic Function -----------------");
            int[] a1 = new int[] { 1, 2, 3, 4, 5 };
            int[] a2 = new int[] { 1, 2, 3, 4, 5, 6 };
            double[] d1 = new double[] { 1.1, 1.2, 1.3, 1.4, 1.5 };
            double[] d2 = new double[] { 1.1, 1.2, 1.3, 1.4, 1.5, 1.6 };
            Function.Zip(d1, d2);
            Action<int, int> add = Function.Add; add(1, 2);
            Action<double, double> Mul = Function.Mul; Mul(1.0, 3.0);

            Console.WriteLine("----------------------- Enum -------------------------");
            Console.WriteLine((int)Level.Employee);
            Console.WriteLine((int)Level.Manager);
            Console.WriteLine((int)Level.Boss);
            Console.WriteLine((int)Level.BigBoss);

            Person person = new Person();
            person.Skill = Skill.Cook | Skill.Drive | Skill.Program | Skill.Teach;
            Console.WriteLine(person.Skill);
            Console.WriteLine((person.Skill & Skill.Cook) > 0);

            Console.WriteLine("---------------------- Struct ------------------------");
            
            Stu stu = new Stu() { ID = 1, Name = "夏东南", Age = 24 };
            stu.Speak();
            Console.WriteLine("ID " + stu.ID + "    Name " + stu.Name + "    Age " + stu.Age);
            Console.WriteLine();

        }
    }
}