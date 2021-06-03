using System;

namespace TicTacToegame
{
    class Program
    {
        
        public static char ChooseUserLetter()
        {
            Console.WriteLine("Choose Your Letter O and X: ");
            char userLetter = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(userLetter);
        }
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
            /// who statrt first
            TicTacToe.getWhoStartFirst();
            /// change the turn
             static bool isWinner(char[] board, char ch)
             {
              return((board[1] == ch && board[2] == ch && board[3] == ch) ||     //across the top
                     (board[4] == ch && board[5] == ch && board[6] == ch) ||     //across the middle
                     (board[7] == ch && board[8] == ch && board[9] == ch) ||     //across the top
                     (board[1] == ch && board[4] == ch && board[7] == ch) ||     //across the left                                                    //across the left
                     (board[2] == ch && board[5] == ch && board[8] == ch) ||     //across the middle                                                                                                           //across the middle
                     (board[3] == ch && board[6] == ch && board[9] == ch) ||     //across the right                                                    //across the right
                     (board[1] == ch && board[5] == ch && board[9] == ch) ||     //across the top left diagonal
                     (board[7] == ch && board[5] == ch && board[3] == ch));      //across the bottom left diagonal
             }
            char userLetter = ChooseUserLetter();
            Console.WriteLine("check if won" + isWinner(board,userLetter)); ///change the turn



        }

    }

}   
