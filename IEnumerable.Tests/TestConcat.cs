using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestConcat
    {
        [TestMethod]
        public void ShouldConcatTwoSequences()
        {
            var _1to5 = Enumerable.Range(1, 5);
            var _6To10 = Enumerable.Range(6, 5);

            var result = _1to5.Concat(_6To10);

            Assert.AreEqual(10, result.Count());
            CollectionAssert.AreEqual(Enumerable.Range(1, 10).ToArray(), result.ToArray());            
        }

        [TestMethod]
        public void ShouldConcatAnEmptySequenceToANonEmptySequence()
        {
            var empty = Enumerable.Empty<int>();
            var _1to5 = Enumerable.Range(1, 5);
            var result = empty.Concat(_1to5);

            Assert.AreEqual(5, result.Count());
            CollectionAssert.AreEqual(Enumerable.Range(1, 5).ToArray(), result.ToArray());
        }

        [TestMethod]
        public void ShouldConcatTwoEmptySequences()
        {
            var anEmpty = Enumerable.Empty<int>();
            var anotherEmpty = Enumerable.Empty<int>();

            var result = anEmpty.Concat(anotherEmpty);

            Assert.AreEqual(0, result.Count());
        }
    }
}
