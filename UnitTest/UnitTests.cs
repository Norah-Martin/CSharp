using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod()
        {
            Employee emp = new Employee();
            var result=emp.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Employee emp = new Employee();
            var result = emp.Add(1, 3);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Employee emp = new Employee();
            var result = emp.Add(3, 3);
            Assert.AreEqual(6, result);
        }
    }
}
