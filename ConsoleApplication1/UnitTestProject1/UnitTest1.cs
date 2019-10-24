using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPush()
        {
            Stack s = new Stack();
            s.Push("1");
            s.Push("2");
            s.Push("3");
            Assert.AreEqual("3", s.Pop());
            Assert.AreEqual("2", s.Pop());
        }
        public void TestPeek()
        {
            Stack s = new Stack();
            s.Push("1");
            s.Push("2");
            s.Push("3");
            Assert.AreEqual("3", s.Peek());
            Assert.AreEqual(3, s.Count());
        }
        public void TestClear()
        {
            Stack s = new Stack();
            s.Push("1");
            s.Push("2");
            s.Push("3");
            Assert.AreEqual("3", s.Clear());
            Assert.AreEqual(3, s.Count());
        }
    }
}
