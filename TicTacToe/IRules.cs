using System;
using System.Runtime.Remoting.Messaging;

namespace TicTacToe
{
    public class Rules
    {
        private readonly int[][] _board;

        public Rules()
        {
            _board = new int[2][];
            _board[0] = new[] { -1, -1, -1 };
            _board[1] = new[] { -1, -1, -1 };
            _board[2] = new[] { -1, -1, -1 };
        }

        public bool IsCellEmpty(int x, int y)
        {
            return _board != null && _board[x][y] == -1;
        }

        public void Winner()
        {
            // winner logic
        }
        public void MarkCell(int mark,int x, int y)
        {
            if (IsCellEmpty(x, y))
            {
                _board[x][y] = mark;
                return;
            }

            Console.WriteLine("Cell is already occupied.");
        }
        public bool CanDetermine()
        {

            return false;
        }
        public bool RowRule()
        {
            foreach (var row in _board)
            {
                if (row[0] != row[1]) continue;
                if (row[0] == row[2])
                {
                    return true;
                }
            }
            return false;
        }

        public bool ColRule()
        {
            for (var i = 0; i < 3; i++)
            {
                if (_board[i][0] != _board[i][1]) continue;
                if (_board[i][0] == _board[i][2])
                {
                    return true;
                }
            }
            return false;
        }

        public bool DiagonalRule()
        {
            if (_board[0][0] == _board[1][1])
            {
                if (_board[0][0] == _board[2][2])
                {
                    return true;
                }
            }

            if (_board[0][2] != _board[1][1]) return false;
            return _board[0][2] == _board[2][0];
        }

    }
}
