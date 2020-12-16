using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{

    public enum Level
    {
        Employee = 100,
        Manager = 101,
        Boss = 99,
        BigBoss,
    }

    public enum Skill
    {
        Drive = 1,
        Program = 2,
        Cook = 4,
        Teach = 8
    }

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
        public Skill Skill { get; set; }
    }

}
