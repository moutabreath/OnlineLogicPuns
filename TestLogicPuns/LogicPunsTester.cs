using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineLogicPuns;

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

        [TestMethod]
        public void TestSpiralMatrixCalculation()
        {
            const int numberOfColumns = 4;
            const int numberOfRows = 4;
            int[,] valueArray = new int[numberOfRows, numberOfColumns] { { 1, 2, 3, 4 }, { 12, 13, 14, 5 }, { 11, 16, 15, 6 }, { 10, 9, 8, 7 } };

            SpiralMatrixCalculation spiralMatrixCalculation = new SpiralMatrixCalculation();
            spiralMatrixCalculation.CalculateMatrixSum(valueArray, numberOfColumns, numberOfRows);
        }
    }
}
