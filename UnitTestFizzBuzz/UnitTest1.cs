using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Division_By_Three()
        {
            // Step 1 arrange
            bool expected = true;
            bool actual;

            FizzBuzzClass fb = new FizzBuzzClass();

            // Step 2 act
            actual = fb.Fizz(3);
            // Step 3 assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Division_By_Five()
        {
            // Step 1 arrange
            bool expected = true;
            bool actual;

            FizzBuzzClass fb = new FizzBuzzClass();

            // Step 2 act
            actual = fb.Buzz(5);
            // Step 3 assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Division_By_Three_And_Five()
        {
            bool expected = true;
            bool actual;

            FizzBuzzClass fb = new FizzBuzzClass();

            actual = fb.FizzAndBuzz(15);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Not_By_Three_And_Five()
        {
            bool expected = true;
            bool actual;

            FizzBuzzClass fb = new FizzBuzzClass();

            actual = fb.PrintNumbers(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
