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
    }
}