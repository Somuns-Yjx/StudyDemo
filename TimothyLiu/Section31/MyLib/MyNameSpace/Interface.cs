using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{
    interface IUnique<Tid>
    {
         Tid ID { get; set; }
    }
    public class Student<Tid> : IUnique<Tid>
    {
        public Tid ID { get; set; }
        public string Name { get; set; }
    }
    public class Student2: IUnique<ulong>
    {
        public ulong  ID { get; set; }
        public string Name { get; set; }
    }
}
