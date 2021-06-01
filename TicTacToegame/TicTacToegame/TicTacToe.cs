using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToegame
{   /// <Create_board_of_char[]_of_size_10 >
    class TicTacToe
    {
        public void GameBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i < board.Length; i++) 
            {
                board[i] = ' ';
            }
        }
    }
}
