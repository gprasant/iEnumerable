using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IEnumerable.Tests
{
    [TestClass]
    public class TestCopyToDataTable
    {
        [TestMethod]
        public void ShouldCopyASequenceToDataTable()
        {
            var sequence = Enumerable.Range(1, 10);
            //var dataTable = sequence.CopyToDataTable();
        }
    }
}
