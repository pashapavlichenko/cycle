using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WhileA.Tests
{
    [TestClass]
    public class WhileTest
    {
        [TestMethod]
        public void While1_12and5_2expected()
        {
            
            int x = 12;
            int y = 5;
            int expected = 2;

            
            WhileTasks t = new WhileTasks();
            int actual = t.While1(x, y);

           
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void While21_2221_TRUEexpected()
        {
            // arrange
            int x = 2221;
            string expected = "TRUE";

            // act
            WhileTasks t = new WhileTasks();
            string actual = t.While21(x);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}