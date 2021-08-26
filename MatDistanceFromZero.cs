using System;

namespace Codility
{
    public class MatZeroDistances
    {
        bool[][] visited;
        int[][] myMat;
        const int initValue = int.MaxValue;
        public int[][] UpdateMatrix(int[][] mat)
        {
            myMat = new int[mat.Length][];
            visited = new bool[mat.Length][];
            int i = 0;
            for (i = 0; i < mat.Length; i++)
            {
                myMat[i] = new int[mat[i].Length];
                visited[i] = new bool[mat[i].Length];
            }
            for (i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    myMat[i][j] = initValue;
                }
            }
        
            for (i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    myMat[i][j] = CellDistance(i, j, mat, visited);
                    for (int k = j + 1; k < mat[i].Length; k++)
                    {
                        myMat[i][k] = initValue;
                        visited[i][k] = false;
                    }
                    for (int k = i + 1; k < mat.Length; k++)
                    {
                        for (int l = 0; l < mat[k].Length; l++)
                        {
                            myMat[k][l] = initValue;
                            visited[k][l] = false;
                        }
                    }

                    Print(i, j);
                }
            }
            return myMat;
        }

        private int CellDistance(int i, int j, int[][] mat, bool[][] visited)
        {
            int min = 0;
            if (visited[i][j])
            {
                return myMat[i][j];
            }
            visited[i][j] = true;
            
            if (mat[i][j] == 0) return 0;
            
            if ((i - 1 >= 0) && (j - 1 >= 0) && (i + 1 < mat.Length) && (j + 1 < mat[i].Length))
            {
                min = 1 + Math.Min(
                    Math.Min(CellDistance(i - 1, j, mat, visited), CellDistance(i, j - 1, mat, visited)),
                    Math.Min(CellDistance(i + 1, j, mat, visited), CellDistance(i, j + 1, mat, visited))
                    );
                myMat[i][j] = min;
                return min;
            }

            if ((i - 1 >= 0) && (j - 1 >= 0) && (i + 1 < mat.Length))
            {
                min = 1 + Math.Min(
                        Math.Min(CellDistance(i - 1, j, mat, visited), CellDistance(i, j - 1, mat, visited)),
                        CellDistance(i + 1, j, mat, visited)
                        );
                myMat[i][j] = min;
                return min;
            }
            if ((i - 1 >= 0) && (j - 1 >= 0) && (j + 1 < mat[i].Length))
            {
                min = 1 + Math.Min(
                    Math.Min(CellDistance(i - 1, j, mat, visited), CellDistance(i, j - 1, mat, visited)),
                    CellDistance(i, j + 1, mat, visited)
                    );
                myMat[i][j] = min;
                return min;
            }
            if ((i - 1 >= 0) && (i + 1 < mat.Length) && (j + 1 < mat[i].Length))
            {
                min = 1 + Math.Min(
                     Math.Min(CellDistance(i - 1, j, mat, visited), CellDistance(i + 1, j, mat, visited)),
                     CellDistance(i, j + 1, mat, visited)
                 );
                myMat[i][j] = min;
                return min;
            }

            if ((j - 1 >= 0) && (i + 1 < mat.Length) && (j + 1 < mat[i].Length))
            {
                min = 1 + Math.Min(
                     Math.Min(CellDistance(i, j - 1, mat, visited), CellDistance(i + 1, j, mat, visited)),
                     CellDistance(i, j + 1, mat, visited)
                     );
                myMat[i][j] = min;
                return min;
            }
            if ((j - 1 >= 0) && (i - 1 >= 0) && (j + 1 < mat[i].Length))
            {
                min = 1 + Math.Min(
                     Math.Min(CellDistance(i - 1, j, mat, visited), CellDistance(i, j - 1, mat, visited)),
                     CellDistance(i + 1, j, mat, visited)
                     );
                myMat[i][j] = min;
                return min;
            }

            if ((i + 1 < mat.Length) && (i - 1 >= 0) && (j - 1 >= 0))
            {
                min = 1 + Math.Min(
                     Math.Min(CellDistance(i + 1, j, mat, visited), CellDistance(i - 1, j, mat, visited)),
                     CellDistance(i, j - 1, mat, visited)
                     );
                myMat[i][j] = min;
                return min;
            }

            if ((j + 1 < mat[i].Length) && (i - 1 >= 0) && (i + 1 < mat.Length))
            {
                min = 1 + Math.Min(
                     Math.Min(CellDistance(i, j + 1, mat, visited), CellDistance(i - 1, j, mat, visited)),
                     CellDistance(i + 1, j, mat, visited)
                     );
                myMat[i][j] = min;
                return min;
            }
            if ((j + 1 < mat[i].Length) && (j - 1 >= 0) && (i + 1 < mat.Length))
            {
                min = 1 + Math.Min(
                     Math.Min(CellDistance(i, j + 1, mat, visited), CellDistance(i, j - 1, mat, visited)),
                     CellDistance(i + 1, j, mat, visited)
                 );
                myMat[i][j] = min;
                return min;
            }
            myMat[i][j] = min;
            return min;
        }

        private void Print(int x, int y)
        {
            Console.WriteLine("point " + x + " " + y);
            Console.WriteLine("matrix");
            for (int i = 0; i < myMat.Length; i++)
            {
                for (int j = 0; j < myMat[i].Length; j++)
                {
                    Console.Write(myMat[i][j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}