using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{
    public interface IMetal
    {
        void Oxidize();
        void Sold();
    }

    public class Iron : IMetal
    {
        private string Name;

        public Iron()
        {
            Name = "Iron";
        }
        public void Oxidize()
        {
            Console.WriteLine(Name + " is oxidized ");
        }
        public void Sold()
        {
            Console.WriteLine(Name + " is sold cheap ");
        }
    }
    public class Aurum : IMetal
    {
        private string Name;

        public Aurum()
        {
            Name = "Aurum";
        }
        public void Oxidize()
        {
            Console.WriteLine(Name + " is merely oxidized ");
        }
        public void Sold()
        {
            Console.WriteLine(Name + " is sold expensive ");
        }
    }

}
