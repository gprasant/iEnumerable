using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestContains
    {
        [TestMethod]
        public void ShouldTestIfSequenceContainsAnItem()
        {
            var sequence = Enumerable.Range(1, 10);
         
            var result = sequence.Contains(10);

            Assert.IsTrue(result);
            
        }

        [TestMethod]
        public void ShouldTestIfASequenceDoesnotContainAnItem()
        {
            var sequence = Enumerable.Range(1, 10);

            var result = sequence.Contains(11);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldTestifEmptySequenceContainsAnItem()
        {
            var sequence = Enumerable.Empty<int>();
                
            var result = sequence.Contains(1);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldtestIfASequenceContainsAnElementGivenComparator()
        {
            var sequence = Enumerable.Range(1, 10);

            var result = sequence.Contains(11, new WeirdIntComparer());

            Assert.IsTrue(result);
        }

        private class WeirdIntComparer : IEqualityComparer<int>
        {

            public bool Equals(int x, int y)
            {
                return x == y - 1;
            }

            public int GetHashCode(int obj)
            {
                return base.GetHashCode();
            }
        }
    }
}
