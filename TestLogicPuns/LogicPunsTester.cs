﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineLogicPuns;
using System.Collections.Generic;

namespace TestLogicPuns
{
    [TestClass]
    public class LogicPunsTester
    {
        [TestMethod]
        public void TestMatDistance()
        {
            int[] first = { 0, 0, 0 };
            int[] second = { 0, 1, 0 };
            int[] third = { 1, 1, 1 };
            int[] resultThird = { 1, 2, 1 };
            int[][] input = { first, second, third };
            int[][] expected = { first, second, resultThird };
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
        public void TestDeletFiveFromInt()
        {
            DeleteFiveFromInt solution = new DeleteFiveFromInt();
            Assert.AreEqual(1958, solution.solution(15958));
            Assert.AreEqual(351285, solution.solution(3512585));
            Assert.AreEqual(-589, solution.solution(-5859));
            Assert.AreEqual(0, solution.solution(-5000));
        }

        [TestMethod]
        public void TestMatZeroDistances()
        {
            MatZeroDistances solution = new MatZeroDistances();
            int[] first = { 0, 0, 0 };
            int[] second = { 0, 1, 0 };
            int[] third = { 1, 1, 1 };
            int[][] mat = new int[][] { first, second, third };
            int[] resultThird = { 1, 2, 1 };

            Assert.AreEqual(solution.UpdateMatrix(mat), new int[][] { first, second, resultThird });
        }

        [TestMethod]
        public void TestMostCommonWord()
        {
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = { "hit" };
            MostCommonWordSolver mostCommonWord = new MostCommonWordSolver();
            Assert.AreEqual("ball", mostCommonWord.FindMostCommonWord(paragraph, banned));
        }

        [TestMethod]
        public void TestRenderClosestObject()
        {
            RenderClosestObjects renderClosestObjects = new RenderClosestObjects();
            int[] D = { 5, 11, 1, 3 };
            int[] C = { 6, 1, 3, 2 };
            Assert.AreEqual(2,renderClosestObjects.solution(D, C, 7));
        }

        [TestMethod]
        public void TestTopKMostFrequent()
        {
            int k = 2;
            string[] keywords = { "anacell", "cetracular", "betacellular" };
            string[] reviews = {  "Anacell provides the best services in the city",
                        "betacellular has awesome services",
                        "Best services provided by anacell, everyone should use anacell"};
            TopKMostFrequent topKMostFrequent = new TopKMostFrequent();
            string[] result = topKMostFrequent.FindTopKMostWantedKeywords(k, keywords, reviews);
            Assert.AreEqual(new string[] { "anacell", "betacellular" }, result);
        }

        [TestMethod]
        public void TestIsCartPromoted()
        {
            List<List<string>> codeList1 = new List<List<string>>(){
            new List<string> { "apple", "apple" },
            new List<string> { "banana", "anything", "banana" } };

            string[] shoppingCart1 = { "orange", "apple", "apple", "banana", "orange", "banana" };
            string[] shoppingCart2 = { "banana", "orange", "banana", "apple", "apple", "anything" };
            string[] shoppingCart3 = { "apple", "banana", "apple", "orange", "banana" };
            string[] shoppingCart4 = { "apple", "apple", "apple", "banana" };
            SelectedItemsPromotions selecctedItemsPromotions = new SelectedItemsPromotions();
            selecctedItemsPromotions.DetermineIfCartIsPromoted(codeList1, shoppingCart1);
        }

        [TestMethod]
        public void TestFindAllPermustations()
        {
            List<string> perms = FindAllPermustations.FindAllPermutations("abcd", 0);
        }

        [TestMethod]
        public void TestFIndMaxStockPrices()
        {
            double[] array = new double[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            array[18] = 21;
            StockPrices.FindMaxStockPrices(array);
        }
    }
}

