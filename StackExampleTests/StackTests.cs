using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample.Tests
{
    [TestClass()]
    public class StackTests
    {

        Stack stack;

        [TestInitialize]
        public void TestInitialize()
        {
            stack = new Stack();
        }

        [TestMethod()]
        public void pushTest()
        {
            stack.push(1);
            Assert.AreEqual(1, stack.peek());
        }

        [TestMethod()]
        public void popTest()
        {
            stack.push(1);
            stack.push(2);
            Assert.AreEqual(2, stack.pop());
            Assert.Fail();
        }

        [TestMethod()]
        public void pushMultipleTest()
        {
            stack.push(1);
            stack.push(2);
            stack.push(3);

            Assert.AreEqual(3, stack.peek());
        }

        [TestMethod()]
        public void popMultipleTest()
        {
            stack.push(1);
            stack.push(2);
            stack.push(3);

            stack.pop();
            Assert.AreEqual(2, stack.pop());
        }
    }
}