using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section25
{
    class Derive
    {
        public static void Show()
        {
            Vehicle v = new Vehicle("v1");
            Ship s = new Ship("s1");
            SpaceShip ss = new SpaceShip("ss1");
        }
        public class Vehicle
        {
            public string Owner { get; set; }
            public Vehicle(string Name)
            {
                Owner = Name;
                Console.WriteLine(Owner);
            }
        }
        internal class Ship : Vehicle
        {
            public Ship(string Name)
                : base(Name)
            {
                // 实例构造器不可被继承
            }
        }
        private class SpaceShip : Vehicle
        {
            public SpaceShip(string Name)
                : base(Name)
            {
                // 实例构造器不可直接被继承
            }
        }
    }

}
