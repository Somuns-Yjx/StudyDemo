using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{
    public class Book
    {
        public string Name { get; set; }
    }
    public class Apple
    {
        public string Color { get; set; }
    }
    /*-------------------Version 1.0 & 1.1 ----------------------*/
    public class Box
    {
        //public Apple Apple { get; set; }
        //public Book Book { get; set; }
        public Object Cargo { get; set; }
    }
    /*-------------------Version 1.2 ----------------------*/
    public class NewBox<TCargo>
    {
        public TCargo Cargo { get; set; }
    }


}
