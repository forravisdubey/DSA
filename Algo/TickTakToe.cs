using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorigthms
{
    public class TicTacToe
    {
        int[,] board = null;
        int boardSize = 0;
        public TicTacToe(int n)
        {

            board = new int[n, n];
            boardSize = n;
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    board[i, j] = 0;

                }
            }

        }

        public int Move(int row, int col, int player)
        {
            bool rowFilled = false;
            if (player == 1)
            {
                board[row, col] = 1;
            }
            else
            {
                board[row, col] = 2;
            }

            int count = 0;
            int sum = 0;
            for (int i = 0; i < boardSize; i++)
            {
                if (board[i, col] != 0)
                {
                    count++;
                    sum = sum + board[i, col];
                }
            }
            int playeId = -1;
            if (CheckWinner(count, sum, out playeId)) return playeId;

            count = 0;
            sum = 0;
            for (int i = 0; i < boardSize; i++)
            {
                if (board[row, i] != 0)
                {
                    count++;
                    sum = sum + board[row, i];
                }
            }

            playeId = -1;
            if (CheckWinner(count, sum, out playeId)) return playeId;

            count = 0;
            sum = 0;
            for (int i = 0; i < boardSize; i++)
            {
                if (board[i, i] != 0)
                {
                    count++;
                    sum = sum + board[i, i];
                }
            }

            playeId = -1;
            if (CheckWinner(count, sum, out playeId)) return playeId;

            count = 0;
            sum = 0;
            for (int i = 0; i < boardSize; i++)
            {
                if (board[boardSize - i - 1, i] != 0)
                {
                    count++;
                    sum = sum + board[boardSize - i - 1, i];
                }
            }

            playeId = -1;
            if (CheckWinner(count, sum, out playeId)) return playeId;

            return 0;
        }

        public bool CheckWinner(int count, int sum, out int player)
        {
            player = -1;
            if ((count == boardSize && sum == boardSize))
            {
                player = 1;
                return true;
            }
            if ((count == boardSize && sum == 2 * boardSize))
            {
                player = 2;
                return true;
            }
            return false;
        }

    }
}
