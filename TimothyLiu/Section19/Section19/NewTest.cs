using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section19
{
    class NewTest
    {
        public static void Show()
        {
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();
            Action<Product> Logs = new Action<Product>(Logger.Log);

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);


            Box box1 = wrapFactory.WrapProduct(func1, Logs);
            Box box2 = wrapFactory.WrapProduct(func2, Logs);
            Console.WriteLine(box1.Products.Name);
            Console.WriteLine(box2.Products.Name);

        }
        class Product
        {
            public string Name { get; set; }
            public int Pirce { get; set; }
        }
        class Box
        {
            public Product Products { get; set; }
        }
        class WrapFactory
        {
            public Box WrapProduct(Func<Product> getProduct, Action<Product> getLog)
            {
                Box box = new Box();
                Product product = getProduct();
                box.Products = product;
                getLog(product);
                return box;
            }
        }
        class Logger
        {
            public static void Log(Product product)
            {
                Console.WriteLine(product.Name + " created at " + DateTime.UtcNow + " price is " + product.Pirce);
            }
        }
        class ProductFactory
        {
            public Product MakePizza()
            {
                Product product = new Product();
                product.Name = "Pizza";
                product.Pirce = 12;
                return product;
            }
            public Product MakeToyCar()
            {
                Product product = new Product();
                product.Name = "Toy Car";
                product.Pirce = 100;
                return product;
            }
        }


    }
}
