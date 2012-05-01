using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestAggregate
    {
        Func<int, int, int> sum = (a, b) => a + b;
        [TestMethod]
        public void ShouldAggregateAllElementsInASequence()
        {
            var sequence = Enumerable.Range(1, 2);
            
            int total = sequence.Aggregate(sum);
            
            Assert.AreEqual(total, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ShouldAggregateOverAnEmptySequence()
        {
            var sequence = Enumerable.Empty<int>();
            
            var total = sequence.Aggregate(sum);
        }

        [TestMethod]
        public void ShouldAggregateOverElementsInASequenceGivenASeed()
        {
            var sequence = Enumerable.Range(1, 2);
            
            var total = sequence.Aggregate(10, (a, b) => a + b);
           
            Assert.AreEqual(total, 13);
        }

        [TestMethod]
        public void ShouldAggregateAndSelectAValueFromFinalResult()
        {
            var sequence = Enumerable.Range(1, 2);
            
            var total = sequence.Aggregate(0, sum, x => new{IntValue = x});
            
            Assert.AreEqual(total.IntValue, 3);
        }
    }
}
