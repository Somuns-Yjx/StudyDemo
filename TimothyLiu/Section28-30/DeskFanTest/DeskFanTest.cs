using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib.MyNameSpace;

namespace DeskFanTest
{
    [TestClass]
    public class DeskFanTest
    {
        [TestMethod]
        public void WorkTest()
        {
            string expect = "Work Fine";
            var df = new DeskFan(new Power1());
            Assert.IsTrue(expect == df.Work());
        }
        class Power1 : IPowerSuply
        {
            public int GetPower() { return 200; }
        }
    }
}
