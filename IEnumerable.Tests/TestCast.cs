using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestCast
    {
        [TestMethod]
        public void ShouldCastASequence()
        {
            int[] sequence = new int[] {1, 2, 3};
            var result = sequence.Cast<decimal>();

            Assert.IsInstanceOfType(sequence, typeof(IEnumerable<int>));
            Assert.IsInstanceOfType(result, typeof(IEnumerable<decimal>));
            Console.WriteLine(sequence.ElementAt(0));
            var iter = result.GetEnumerator();
            iter.MoveNext();
            Console.WriteLine(iter.Current);
            Assert.IsInstanceOfType(result.ElementAt(0), typeof(decimal));
        }
    }
}
