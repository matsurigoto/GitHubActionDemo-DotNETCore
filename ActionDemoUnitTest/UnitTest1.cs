using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ActionDemoUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(12, 30, 42)]
        [DataRow(14, 1, 15)]
        public void Test_Add(int a, int b, int expected)
        {
            var actual = a + b;
            Assert.AreEqual(expected, actual);
        }
    }
}
