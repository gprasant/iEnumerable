using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestDistinct
    {
        [TestMethod]
        public void ShouldGetDistinctElements()
        {
            var repeated = Enumerable.Repeat(1, 10);

            var result = repeated.Distinct();

            Assert.AreEqual(1, result.Count());
            Assert.AreEqual(1, result.First());
        }

        [TestMethod]
        public void ShouldGetResultElementsInTheSameOrderAsInput()
        {
            int[] arr = new int[]{1, 2, 3, 1, 2};
            
            var result = arr.Distinct();

            CollectionAssert.AreEqual(new []{1, 2, 3}, result.ToArray());
        }
    }
}
