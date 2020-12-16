using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{
    interface ISpeak
    {
        void Speak();
    }
    public struct Stu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void Speak()
        {
            Console.WriteLine("I have achieved it !");
        }
    }
}
