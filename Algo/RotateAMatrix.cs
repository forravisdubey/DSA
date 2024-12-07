using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class RotateAMatrix
    {
        //tranposing mean row means nth row becomes nth column
        public static int[,] TransposeMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);

            int[,] result = new int[rowCount, rowCount];


            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < rowCount; column++)
                {
                    result[column,row] = matrix[row,column];
                }
            }

            return result;
        }

        //tranposing mean row means nth row becomes nth column
        public static int[,] ReflectMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int[,] result = new int[rowCount, rowCount];
            for (int column = 0; column < rowCount; column++)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    result[row,column] = matrix[row, rowCount-column-1];
                }
            }

            return result;
        }

        //tranposing mean row means nth row becomes nth column
        /// <summary>
        /// [0,0] -> [lastIndex=3,0]
        /// [0,1] -> [2,0]
        /// [0,2] -> [1,0]
        /// [0,3] -> [0,0]
        /// row,col -> lastIndex-col,row
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[,] RotateMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int[,] result = new int[rowCount, rowCount];
            for (int column = 0; column < rowCount; column++)
            {
                for (int row = 0; row < rowCount; row++)
                {
                    result[row, column] = matrix[rowCount - column - 1, row ];
                }
            }

            return result;
        }

        //tranposing mean row means nth row becomes nth column
        /// <summary>
        /// [0,0] -> [lastIndex=3,0]
        /// [0,1] -> [2,0]
        /// [0,2] -> [1,0]
        /// [0,3] -> [0,0]
        /// row,col -> lastIndex-col,row
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[,] RotateMatrixInPlace(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);

            //for (int column = 0; column < rowCount/2; column++)
            //{
            //    for (int row = column; row < rowCount-column-1; row++)
            //    {
            //        var temp1 = matrix[row, column]; //row , col -> totalIndex-col, row , row = 0, col= 1
            //        var temp2 = matrix[rowCount - column - 1, row];
            //        var temp3 = matrix[rowCount - column - 1, rowCount - row-1];

            //        matrix[rowCount - row - 1, rowCount - column - 1] = temp3;
            //        matrix[rowCount - column - 1, rowCount - row - 1] = temp2;
            //        matrix[rowCount - column - 1, row] = temp1;
            //        matrix[row, column] = matrix[rowCount - column - 1, row];

            //    }
            //}

            return matrix;
        }


    }
}
