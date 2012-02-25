using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestAsEnumerable
    {
        [TestMethod]
        public void ShouldTestAncestor()
        {
            var sequence = new int[] {1, 2};

            var result = sequence.AsEnumerable();
            
            Assert.IsInstanceOfType(result, typeof(IEnumerable<int>));
        }
    }
}
