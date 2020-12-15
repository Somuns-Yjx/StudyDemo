using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{
    #region Abstract
    public abstract class Section28
    {
        public Section28()
        {
            Name = "Animal";
        }
        public string Name { get; set; }
        public abstract void Eat();
    }
    public class Monkey : Section28
    {
        public Monkey()
        {
            Name = "Monkey";
        }
        public override void Eat()
        {
            Console.WriteLine(Name + " is eating .");
        }
    }
    public class Bird : Section28
    {
        public Bird()
        {
            Name = "Bird";
        }
        public void Fly()
        {
            Console.WriteLine("Bird is flying .");
        }
        public override void Eat()
        {
            Console.WriteLine(Name + " is eating .");
        }
    }
    public class Human : Section28
    {
        public Human()
        {
            Name = "Human";
        }
        public override void Eat()
        {
            Console.WriteLine(Name + " is having the meal .");
        }
        public void MakeDishes()
        {
            Console.WriteLine(Name + " is making dishes .");
        }
    }
    #endregion

    #region Interface
    public interface IVehicle
    {
        void Fly();
        void Accelerate();
        void SlowDown();
    }
    public class Pilot : IVehicle
    {
        public void Fly()
        {
            Console.WriteLine("Pilot is flying .");
        }
        public void Accelerate()
        {
            Console.WriteLine("Pilot is accelerating .");
        }
        public void SlowDown()
        {
            Console.WriteLine("Pilot is slowing down .");
        }
    }
    #endregion




}
