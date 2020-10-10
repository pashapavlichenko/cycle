using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForA.Tests
{
    [TestClass]
    public class ForTests
    {
        [TestMethod]
        public void For9_4and9_13returned()
        {
            // arrange
            int x = 4;
            int y = 9;
            int expected = 13;

            // act
            Tasks t = new Tasks();
            int actual = t.For9(x, y);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void For13_19_2returned()
        {
            
            decimal x = 19M;
            decimal expected = 2M;

            
            Tasks t = new Tasks();
            decimal actual = t.For13(x);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void For21_2_TwoAndHalfreturned()
        {
            // arrange
            int x = 2;
            double expected = 2.5;

            // act
            Tasks t = new Tasks();
            double actual = t.For21(x);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}