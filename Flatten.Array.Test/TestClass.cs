using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;

namespace Flatten.Array.Test
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void Should_Return_Normal_Array_Ok()
        {
            var array = new object[] { 1, 2, 3, 4, 5, 6 };
            var sut = new ArrayTransform();
            sut.SolveArray(array);

            Assert.AreEqual(6, sut.FinalArray.Count);

        }

        [TestMethod]
        public void Should_Return_Nested_Array_Ok()
        {
            var array = new object[] { 1, 2, new object[] { 3, 4, 5 } };
            var sut = new ArrayTransform();
            sut.SolveArray(array);

            Assert.AreEqual(5, sut.FinalArray.Count);

        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Should_Exception_Array_not_integer_Ok()
        {
            var array = new object[] { 1, "string", new object[] { 3, 4, 5 } };
            var sut = new ArrayTransform();

            sut.SolveArray(array);
        }
    }
}
