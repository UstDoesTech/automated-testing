using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddNumberTest_10Plus20Equal30()
        {
            int r = Calculator.AddNumber(10, 20);
            Assert.AreEqual(30, r);
        }
    }
}

