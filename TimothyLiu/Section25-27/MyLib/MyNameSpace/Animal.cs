using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{
    public class Animal
    {
        private const int totalHunger = 8;
        protected double hunger = totalHunger;
        public string Name { get; set; }
        protected double amount { get; set; }
        protected void Eat(int times, double amount)
        {
            double temp = hunger - amount * times;
            hunger = temp >= 0 ? temp : hunger;
        }
        public Animal(string name, int eatTimes)
        {
            Name = name;
        }
        ~Animal()
        {
        }
    }

    public class Tiger : Animal
    {
        public Tiger(string name, int times)
            : base(name, times)
        {
            amount = 2;
            Eat(times, amount);
            Console.WriteLine("Name : " + Name + "\nHunger is " + hunger + "\n");
        }
    }

    public class Squirrel : Animal
    {
        public Squirrel(string name, int times)
            : base(name, times)
        {
            amount = 0.5;
            Eat(times, amount);
            Console.WriteLine("Name : " + Name + "\nHunger is " + hunger + "\n");
        }
    }
    public sealed class NewAnimal : Animal
    {
        public NewAnimal(string name, int times)
            : base(name, times)
        {

        }
    }

}
