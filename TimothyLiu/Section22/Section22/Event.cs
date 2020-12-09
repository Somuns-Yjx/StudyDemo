using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section22
{
    #region 事件完整声明
    public class Restaurant
    {
        public static void Show()
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayTheBill();
        }
    }
    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class Waiter
    {
        public void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("Waiter will serve you the dish {0} ", e.DishName);
            double price = 10;
            switch (e.Size)
            {
                case "large":
                    price *= 1.5;
                    break;
                case "small":
                    price *= 0.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
        }
    }

    public class Customer
    {
        public double Bill { get; set; }
        private OrderEventHandler orderEventHandler;
        public event OrderEventHandler Order
        {
            add
            {
                this.orderEventHandler += value;
            }
            remove
            {
                this.orderEventHandler -= value;
            }
        }

        public void WalkIn()
        {
            Console.WriteLine("Customer walks in the restaurant .");
        }
        public void SitDown()
        {
            Console.WriteLine("Customer sits down . ");
        }
        public void Think()
        {
            if (orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Yuxiang Pork";
                e.Size = "large";
                Console.WriteLine("Customer orders the {0} ,for {1} size ", e.DishName, e.Size);
                orderEventHandler.Invoke(this, e);
            }
        }

        public void PayTheBill()
        {
            Console.WriteLine("Customer : I will pay {0} yuan . ", Bill);
        }
        public void Action()
        {
            Console.WriteLine();
            WalkIn();
            SitDown();
            Think();
        }
    }
    #endregion

    #region 事件简化声明

    //public class Customer
    //{
        //public event OrderEventHandler Order;

    //}
    #endregion
}
