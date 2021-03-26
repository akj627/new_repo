using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void TestInit1223(TestContext testContext)
        {
            var a = 2 + 5;
            var b = a + 7;
        }

        [TestInitialize]
        public void TestInit123()
        {
            var a = 2 + 5;
            var b = a + 7;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod1()
        {
            ClassLibrary1.Class1 c = new ClassLibrary1.Class1();

            Assert.AreEqual(200, c.Sum(1, 1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            ClassLibrary1.Class1 c = new ClassLibrary1.Class1();

            Assert.AreEqual(300, c.Sum(2, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestArray()
        {
            ClassLibrary1.Class1 c = new ClassLibrary1.Class1();
            int[] arrayOfElem = new int[] {7, 3, 8, 9, 1, 0, 5};
            var ret = c.FindElement(arrayOfElem, 8);
            Assert.AreEqual(2, ret);
            ret = c.FindElement(arrayOfElem, 990);
            Assert.AreEqual(-1, ret);
            ret = c.FindElement(arrayOfElem, 990);
            Assert.AreNotEqual(0, ret);
            ret = c.FindElement(arrayOfElem, 1000);
            Assert.AreNotEqual(0, ret);
        }
    }
}
