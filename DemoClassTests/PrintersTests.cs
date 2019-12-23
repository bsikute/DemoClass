using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoClass.Tests
{
    [TestClass()]
    public class PrintersTests
    {
        [TestMethod()]
        public void PrintTest()
        {
            Assert.AreEqual("Hello World!", Printers.Print());
        }

        [TestMethod()]
        public void AreaTest()
        {
            Assert.AreEqual(12, Printers.Area(2, 6));
        }

        [TestMethod()]
        public void AreaTest1()
        {
            Assert.AreEqual(48, Printers.Area(4, 12));
        }
    }
}