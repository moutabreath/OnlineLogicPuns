using System;

namespace OnlineLogicPuns
{
    public class SpiralMatrixCalculation
    {
        public void CalculateMatrixSum(int[,] valueArray, int numberOfColumns, int numberOfRows)
        {
            int generalSum = 0;
            for (int i = 0; i < numberOfRows; i++)
            {
                generalSum += CalculateSingleRange(i, i, 1, numberOfColumns, valueArray, 1);
                generalSum += CalculateSingleRange(i - 1, 1, numberOfRows - i, i - 1, valueArray, 2);
                // i - 2 because we start from +2 index
                int column = numberOfColumns - (i - 2);
                generalSum += CalculateSingleRange(numberOfColumns - (i - 2), column, -1, i - 2, valueArray, 3);
                generalSum += CalculateSingleRange(numberOfRows - (i - 3), i - 3, -1, i - 3, valueArray, 4);

            }
        }

        private int CalculateSingleRange(int rowNumber, int columnNumber, int step, int end, int[,] valueArray, int direction)
        {
            int miniSum = 0;
            if (direction == 1 || direction == 3)
            {
                while (rowNumber != end - 1)
                {
                    miniSum += Convert.ToInt32(valueArray[rowNumber, columnNumber]);
                    rowNumber += step;
                }
            }
            else
            {
                while (columnNumber != end)
                {
                    try
                    {
                        miniSum += Convert.ToInt32(valueArray[rowNumber, columnNumber]);
                    }
                    catch (Exception e)
                    {
                        var msg = e.Message;
                    }
                    columnNumber += step;
                }
            }
            return miniSum;
        }

    }
}

