using Baksteen.Extensions.WhereNotNull;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ValueTypeEmptyListRemainsEmpty()
        {
            var seq = System.Array.Empty<int?>();
            var result = seq.WhereNotNull();
            CollectionAssert.AreEqual(System.Array.Empty<int>(), result.ToArray());
        }

        [TestMethod]
        public void RefTypeEmptyListRemainsEmpty()
        {
            var seq = System.Array.Empty<string?>();
            var result = seq.WhereNotNull();
            CollectionAssert.AreEqual(System.Array.Empty<string>(), result.ToArray());
        }

        [TestMethod]
        public void ValueTypeListNullsAreRemoved()
        {
            var seq = new int?[] { 1, null, 2, null, null, 3, null, null, null };
            var result = seq.WhereNotNull();
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, result.ToArray());
        }

        [TestMethod]
        public void RefTypeListNullsAreRemoved()
        {
            var seq = new string?[] { "one", null, "two", null, null, "three", null, null, null };
            var result = seq.WhereNotNull();
            CollectionAssert.AreEqual(new string[] { "one", "two", "three" }, result.ToArray());
        }
    }
}
