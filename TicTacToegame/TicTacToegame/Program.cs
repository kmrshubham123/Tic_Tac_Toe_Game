using System;

namespace TicTacToegame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### Welcome to Tic Tac Toe Game #####");
            /// create board
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.GameBoard();
            /// 
            char userLetter = ticTacToe.ChooseUserLetter();
            Console.WriteLine("User Choice is :-"+userLetter);
            Console.ReadKey();

        }
    }
}
