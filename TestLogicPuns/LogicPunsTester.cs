using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineLogicPuns;
using System;
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
            Assert.AreEqual(2, renderClosestObjects.solution(D, C, 7));
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
            List<string> perms = PermutationsFinder.FindAllPermutations("abcd", 0);
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

        [TestMethod]
        public void TestCountCountries()
        {
            CountriesCount countriesCount = new CountriesCount();
            int[][] A = new int[7][];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = new int[3];
            }
            A[0][0] = 5; A[0][1] = 4; A[0][2] = 4;
            A[1][0] = 4; A[1][1] = 3; A[1][2] = 4;
            A[2][0] = 3; A[2][1] = 2; A[2][2] = 4;
            A[3][0] = 2; A[3][1] = 2; A[3][2] = 2;
            A[4][0] = 3; A[4][1] = 3; A[4][2] = 4;
            A[5][0] = 1; A[5][1] = 4; A[5][2] = 4;
            A[6][0] = 4; A[6][1] = 1; A[6][2] = 1;
            Assert.AreEqual(11, countriesCount.solution(A));
        }

        [TestMethod]
        public void TestMaxConsecutiveOnes()
        {
            int[] A = { 1, 1, 0, 1, 1, 1 };
            MaxConsecutiveOnes maxConsecutiveOnes = new MaxConsecutiveOnes();
            Assert.AreEqual(3, maxConsecutiveOnes.FindMaxConsecutiveOnes(A));

        }

        [TestMethod]
        public void TestMinInteger()
        {
            int[] A = { 1, 3, 6, 4, 1, 2 };
            MinInteger bigId = new MinInteger();
            Assert.AreEqual(5, bigId.solution(A));

        }


        [TestMethod]
        public void TestBigId()
        {
            int[] A = { 1, 3, 6, 4, 1, 2 };
            MinInteger bigId = new MinInteger();
            Assert.AreEqual(5, bigId.solution(A));

        }


        [TestMethod]
        public void TestDropbox()
        {
            string[][] queries = new string[][]
{ new [] {"APPEND","Hey"},
 new []{ "APPEND"," you"},
 new []{"APPEND",", don't"},
 new[]{"APPEND"," "},
 new [] {"APPEND","let me down"}};
            string[] output = {"Hey",
 "Hey you",
 "Hey you, don't",
 "Hey you, don't ",
 "Hey you, don't let me down" };
            ConsoleTextEditor consoleTextEditor = new ConsoleTextEditor();
            string[] my = consoleTextEditor.textEditor1_2(queries);
            Assert.AreEqual(output, my);

            queries = new string[][] {
new[] { "APPEND", "Hey, you!" },
 new[] { "BACKSPACE" },
 new[] { "APPEND", "? Impossibel!" },
 new[] { "BACKSPACE" },
 new[] { "BACKSPACE" },
 new[] { "BACKSPACE" },
 new[] { "APPEND", "le!" }};

            output = new string[]{"Hey, you!",
 "Hey, you",
 "Hey, you? Impossibel!",
 "Hey, you? Impossibel",
 "Hey, you? Impossibe",
 "Hey, you? Impossib",
 "Hey, you? Impossible!"};

            my = consoleTextEditor.textEditor1_2(queries);
            Assert.AreEqual(output, my);
        }
    }
}

/***
 * 
queries:
[["APPEND","Hey, you!"], 
 ["BACKSPACE"], 
 ["APPEND","? Impossibel!"], 
 ["BACKSPACE"], 
 ["BACKSPACE"], 
 ["BACKSPACE"], 
 ["APPEND","le!"]]

Output:

undefined

Expected Output:

["Hey, you!", 
 "Hey, you", 
 "Hey, you? Impossibel!", 
 "Hey, you? Impossibel", 
 "Hey, you? Impossibe", 
 "Hey, you? Impossib", 
 "Hey, you? Impossible!"]
 ["APPEND","le!"]]
 * 
 * 
 * 
 * 
 * 
 * queries:
[["APPEND","You'll never find a rainbow if you're looking down"], 
 ["APPEND",""], 
 ["MOVE","-10"], 
 ["APPEND","START. "], 
 ["MOVE","57"], 
 ["APPEND","END."]]

Output:

undefined

Expected Output:

["You'll never find a rainbow if you're looking down", 
 "You'll never find a rainbow if you're looking down", 
 "You'll never find a rainbow if you're looking down", 
 "START. You'll never find a rainbow if you're looking down", 
 "START. You'll never find a rainbow if you're looking down", 
 "START. You'll never find a rainbow if you're looking downEND."]
 * 
 * 
 * 
 * 
 * 
 * queries:
[["APPEND","Never give up"], 
 ["MOVE","12"], 
 ["APPEND","!"], 
 ["MOVE","11"], 
 ["APPEND","!"], 
 ["MOVE","10"], 
 ["APPEND","!"], 
 ["MOVE","9"], 
 ["APPEND","!"], 
 ["MOVE","8"], 
 ["APPEND","!"], 
 ["MOVE","7"], 
 ["APPEND","!"], 
 ["MOVE","6"], 
 ["APPEND","!"], 
 ["MOVE","5"], 
 ["APPEND","!"], 
 ["MOVE","4"], 
 ["APPEND","!"], 
 ["MOVE","3"], 
 ["APPEND","!"], 
 ["MOVE","2"], 
 ["APPEND","!"], 
 ["MOVE","1"], 
 ["APPEND","!"]]

Output:

undefined

Expected Output:

["Never give up", 
 "Never give up", 
 "Never give u!p", 
 "Never give u!p", 
 "Never give !u!p", 
 "Never give !u!p", 
 "Never give! !u!p", 
 "Never give! !u!p", 
 "Never giv!e! !u!p", 
 "Never giv!e! !u!p", 
 "Never gi!v!e! !u!p", 
 "Never gi!v!e! !u!p", 
 "Never g!i!v!e! !u!p", 
 "Never g!i!v!e! !u!p", 
 "Never !g!i!v!e! !u!p", 
 "Never !g!i!v!e! !u!p", 
 "Never! !g!i!v!e! !u!p", 
 "Never! !g!i!v!e! !u!p", 
 "Neve!r! !g!i!v!e! !u!p", 
 "Neve!r! !g!i!v!e! !u!p", 
 "Nev!e!r! !g!i!v!e! !u!p", 
 "Nev!e!r! !g!i!v!e! !u!p", 
 "Ne!v!e!r! !g!i!v!e! !u!p", 
 "Ne!v!e!r! !g!i!v!e! !u!p", 
 * 
 * 
 * 
 * 
 * queries:
[["CREATE","file1"], 
 ["CREATE","file2"], 
 ["SWITCH","file1"], 
 ["APPEND","Welcome to the content of file1!"], 
 ["SWITCH","file2"], 
 ["APPEND","File2 is also here."], 
 ["CREATE","file3"], 
 ["APPEND","Hello"], 
 ["SWITCH","file1"], 
 ["APPEND","How do you do?"], 
 ["MOVE","3"], 
 ["BACKSPACE"], 
 ["SWITCH","file3"], 
 ["APPEND","Try this one!"], 
 ["SWITCH","file2"], 
 ["APPEND","World"], 
 ["SWITCH","file1"], 
 ["UNDO"], 
 ["UNDO"], 
 ["SWITCH","file2"], 
 ["UNDO"], 
 ["UNDO"], 
 ["SWITCH","file3"], 
 ["UNDO"], 
 ["UNDO"], 
 ["SWITCH","file1"], 
 ["REDO"], 
 ["SWITCH","file2"], 
 ["REDO"], 
 ["SWITCH","file3"], 
 ["REDO"]]

Output:

undefined

Expected Output:

["", "", "", "Welcome to the content of file1!", "", "File2 is also here.", "File2 is also here.", "File2 is also here.Hello", "Welcome to the content of file1!", "Welcome to the content of file1!How do you do?", "Welcome to the content of file1!How do you do?", "Wecome to the content of file1!How do you do?", "", "Try this one!", "File2 is also here.Hello", "File2 is also here.HelloWorld", "Wecome to the content of file1!How do you do?", "Welcome to the content of file1!How do you do?", "Welcome to the content of file1!", "File2 is also here.HelloWorld", "File2 is also here.Hello", "File2 is also here.", "Try this one!", "", "", "Welcome to the content of file1
 */
