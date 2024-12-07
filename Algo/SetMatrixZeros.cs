using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class SetMatrixZeros
    {
        public void SetZeroesInPlace(int[][] matrix)
        {
            bool isFirstColZero = false;
            int R = matrix.Length;
            int C = matrix[0].Length;

            for (int i = 0; i < R; i++)
            {

                // Since first cell for both first row and first column is the same i.e. matrix[0][0]
                // We can use an additional variable for either the first row/column.
                // For this solution we are using an additional variable for the first column
                // and using matrix[0][0] for the first row.
                if (matrix[i][0] == 0)
                {
                    isFirstColZero = true;
                }

                for (int j = 1; j < C; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[0][j] = 0;
                        matrix[i][0] = 0;
                    }
                }
            }

            // Iterate over the array once again and using the first row and first column, update the elements.
            for (int i = 1; i < R; i++)
            {
                for (int j = 1; j < C; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            // See if the first row needs to be set to zero as well
            if (matrix[0][0] == 0)
            {
                for (int j = 0; j < C; j++)
                {
                    matrix[0][j] = 0;
                }
            }

            // See if the first column needs to be set to zero as well
            if (isFirstColZero)
            {
                for (int i = 0; i < R; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }
    }
}
