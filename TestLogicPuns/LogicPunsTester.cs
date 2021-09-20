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

        [TestMethod]
        public void TestParenthesis()
        {
            string s = "()";
            Assert.AreEqual(true, BracketMatch.isValid(s));
            
            s = "*******(*********";
            Assert.AreEqual(true, BracketMatch.isValid(s));

            s = "*******(*********))";
            Assert.AreEqual(true, BracketMatch.isValid(s));

            s = "*******(*****)****";
            Assert.AreEqual(true, BracketMatch.isValid(s));

            s = "*******(******))***";
            Assert.AreEqual(true, BracketMatch.isValid(s));

            s = "(*******(*********";
            Assert.AreEqual(true, BracketMatch.isValid(s));

            s = "(*******(";
            Assert.AreEqual(false, BracketMatch.isValid(s));
        }

        [TestMethod]
        public void TestBinaryGap()
        {
            Assert.AreEqual(2, BinaryGap.FindGap(328));
            Assert.AreEqual(1, BinaryGap.FindGap(20));
            Assert.AreEqual(2, BinaryGap.FindGap(51712));
            Assert.AreEqual(3, BinaryGap.FindGap(561892));
            Assert.AreEqual(9, BinaryGap.FindGap(66561));
            Assert.AreEqual(20, BinaryGap.FindGap(6291457));
            Assert.AreEqual(4, BinaryGap.FindGap(74901729));
            Assert.AreEqual(25, BinaryGap.FindGap(805306373));
            Assert.AreEqual(5, BinaryGap.FindGap(1376796946));
            Assert.AreEqual(28, BinaryGap.FindGap(1610612737));
        }

        [TestMethod]
        public void TesDeletFiveFromInt()
        {
            DeleteFiveFromInt solution = new DeleteFiveFromInt();
            Assert.AreEqual(1958, solution.solution(15958));
            Assert.AreEqual(351285, solution.solution(3512585));
            Assert.AreEqual(-589, solution.solution(-5859));
            Assert.AreEqual(0, solution.solution(-5000));
        }

        [TestMethod]
        public void TesMatZeroDistances()
        {
            MatZeroDistances solution = new MatZeroDistances();
            int[] first = { 0, 0, 0 };
            int[] second = { 0, 1, 0 };
            int[] third = { 1, 1, 1 };
            int[][] mat = new int[][] { first, second, third };
            int[] resultThird = { 1, 2, 1 };

            Assert.AreEqual(solution.UpdateMatrix(mat), new int[][] { first, second, resultThird });
        }
    }
}

