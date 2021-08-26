using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLogicPuns
{
    [TestClass]
    public class LogicPunsTester
    {
        [TestMethod]
        public void TestMatDistance()
        {
            int[] first = {0, 0, 0};
            int[] second = {0, 1, 0};
            int[] third = {1, 1, 1};
            int[] resultThird = {1, 2, 1};
            int[][] input = {first, second, third};
            int[][] expected = {first, second, resultThird};
            MatZeroDistances matZeroDistances = new MatZeroDistances();
            Assert.AreEqual(matZeroDistances.UpdateMatrix(input), expected);
        }
    }
}
