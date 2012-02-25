using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestAverage
    {
        [TestMethod]
        public void ShouldCalculateAverageOfASequence()
        {
            var sequence = Enumerable.Range(1, 10);

            double average = sequence.Average();

            Assert.AreEqual(average, 5.5);
        }

        [TestMethod]
        public void ShouldAverageAfterApplyingATransform()
        {
            var sequence = Enumerable.Range(1, 10);

            decimal average = sequence.Average(x => Convert.ToDecimal(x));

            Assert.AreEqual(5.5m, average);
        }

        [TestMethod]
        public void ShouldAverageAfterApplyingANullableTransform()
        {
            var sequence = Enumerable.Range(1, 10);

            decimal? average = sequence.Average(x => x==10? x : (decimal?)null);

            Console.WriteLine(average.HasValue);
            Assert.AreEqual(10m, average.Value);
        }
    }
}
