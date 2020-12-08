using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Section19
{
    class Test
    {
        // 委托事件
        public class Delegate
        {
            public delegate double del(double x, double y);
            public static void Show()
            {
                Calculator calculator = new Calculator();
                Action action = new Action(calculator.Report);
                action(); // action.Invoke();
                Func<double, double, double> func1 = new Func<double, double, double>(calculator.Add);
                Func<double, double, double> func2 = new Func<double, double, double>(calculator.Sub);
                double res = func1(1, 2);
                Console.WriteLine("Func1 Show " + res);
                res = func2(1, 2);
                Console.WriteLine("Func2 Show " + res);

                Console.WriteLine("------------------------------------");
                del del1 = new del(calculator.Add);
                del del2 = new del(calculator.Sub);
                del del3 = new del(calculator.Mul);
                del del4 = new del(calculator.Div);
                double x = 100;
                double y = 200;
                Console.WriteLine(del1(x, y));
                Console.WriteLine(del2(x, y));
                Console.WriteLine(del3(x, y));
                Console.WriteLine(del4(x, y));

            }
            public class Calculator
            {
                public void Report()
                {
                    Console.WriteLine("Action Show");
                    Console.WriteLine("------------------------------------");
                }
                public double Add(double a, double b)
                {
                    return a + b;
                }
                public double Sub(double a, double b)
                {
                    return a - b;
                }
                public double Mul(double a, double b)
                {
                    return a * b;
                }
                public double Div(double a, double b)
                {
                    return a / b;
                }
            }
        }

        public class Delegate2
        {
            public static void Show()
            {
                ProductFactory productFactory = new ProductFactory();
                WrapFactory wrapFactory = new WrapFactory();

                Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
                Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

                Box box1 = wrapFactory.WrapProduct(func1);
                Box box2 = wrapFactory.WrapProduct(func2);
                Console.WriteLine(box1.Products.Name);
                Console.WriteLine(box2.Products.Name);

            }
            class Product
            {
                public string Name { get; set; }
            }
            class Box
            {
                public Product Products { get; set; }
            }
            class WrapFactory
            {
                public Box WrapProduct(Func<Product> getProduct)
                {
                    Box box = new Box();
                    Product product = getProduct();
                    box.Products = product;
                    return box;
                }
            }
            class ProductFactory
            {
                public Product MakePizza()
                {
                    Product product = new Product();
                    product.Name = "Pizza";
                    return product;
                }
                public Product MakeToyCar()
                {
                    Product product = new Product();
                    product.Name = "Toy Car";
                    return product;
                }
            }
        }

        public class ThreadTest
        {
            public static void Show()
            {
                Student s1 = new Student() { ID = 1, Color = ConsoleColor.Blue };
                Student s2 = new Student() { ID = 2, Color = ConsoleColor.Green };
                Student s3 = new Student() { ID = 3, Color = ConsoleColor.Cyan };

                Action a1 = new Action(s1.DoHomework);
                Action a2 = new Action(s2.DoHomework);
                Action a3 = new Action(s3.DoHomework);
                a1();   // a1 += a2; a1 += a3; 则为多播委托，执行a1等同a1a2a3
                a2();
                a3();
            }
            public class Student
            {
                public int ID { get; set; }
                public ConsoleColor Color { get; set; }

                public void DoHomework()
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.ForegroundColor = this.Color;
                        Console.WriteLine("Student {0} is doing homework for {1} hour(s)", this.ID, i);
                        Thread.Sleep(500);
                    }
                }
            }
        }

        public class InterFace
        {
            public static void Show()
            {
 
            }
            interface IProductFactory
            {
                Product Make();
            }
            public class Product
            {
                public string Name { get; set; }
            }

            public class PizzaFactory : IProductFactory
            {
                public Product Make()
                {
                    Product product = new Product();
                    product.Name = "Pizza";
                    return product;
                }
            }
            public class ToyCarFactory : IProductFactory
            {
                public Product Make()
                {
                    Product product = new Product();
                    product.Name = "Toy Car";
                    return product;
                }
            }
        }


    }
}
