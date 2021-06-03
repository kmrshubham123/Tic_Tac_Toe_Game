using System;

namespace TicTacToegame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### Welcome to Tic Tac Toe Game #####");
            /// create board
            char[] board = TicTacToe.GameBoard();
            Console.WriteLine(board);
            /// choose letter x and o
            char choose = TicTacToe.ChooseUserLetter();
            Console.WriteLine("Your choice is " + choose);
            /// showBoard function call
            TicTacToe.showBoard(board);
            ///make a move
            int userMove = TicTacToe.GetUserMove(board);
            TicTacToe.makeMove(board, userMove, choose);
            ///
            TicTacToe.getWhoStartFirst();
        
        }   

    }

}   
