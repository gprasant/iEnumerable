using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestAll
    {
        private Func<int, bool> isOdd= x => x%2 == 1;

        [TestMethod]
        public void ShouldTestAllElementsInASequence()
        {
            var sequence = new[] {1, 3, 5};
            
            Assert.IsTrue(sequence.All(isOdd));
        }

        [TestMethod]
        public void ShouldTestAllOnEmptySequence()
        {
            var sequence = Enumerable.Empty<int>();
            
            var result = sequence.All(isOdd);

            Assert.IsTrue(result);
        }
    }
}
