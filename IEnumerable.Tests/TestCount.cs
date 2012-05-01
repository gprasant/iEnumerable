using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestCount
    {
        [TestMethod]
        public void ShouldCountNumberOfItemsInASequence()
        {
            var empty = Enumerable.Empty<int>();

            var result = empty.Count();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ShouldCountNumberOfItemsThatSatisfyACriteria()
        {
            IEnumerable<int> _1to10 = Enumerable.Range(1, 10);
            Func<int, bool> isEven = x => x%2 == 0;
            
            var result = _1to10.Count(isEven);

            Assert.AreEqual(5, result);
        }

    }
}
