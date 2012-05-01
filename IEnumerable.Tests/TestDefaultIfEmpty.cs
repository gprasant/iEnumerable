using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestDefaultIfEmpty
    {
        [TestMethod]
        public void ShouldReturnZeroForAnIntSequence()
        {
            var sequence = Enumerable.Empty<int>();
            
            var result = sequence.DefaultIfEmpty();
            Console.WriteLine(result);
            Assert.AreEqual(0, result.First());
        }

        [TestMethod]
        public void ShouldReturnTheDefaultValueIfSpecified()
        {
            int [] arr = new int[0];
            
            var result = arr.DefaultIfEmpty(5);

            Assert.AreEqual(5, result.First());
        }

    }
}
