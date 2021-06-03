using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToegame
{   /// <Create_board_of_char[]_of_size_10 >
    class TicTacToe
    {
        public static char[] GameBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i < board.Length; i++) 
            {
                board[i] = ' ';
                Console.WriteLine(board[i]);
            }
            return board;
        }
        /// create a method to player choose a letter input X and O 
        
        public static char ChooseUserLetter()
        {
            Console.WriteLine("Choose Your Letter O and X: ");
            char userLetter =Convert.ToChar(Console.ReadLine());
            return char.ToUpper(userLetter);
        }
        
        /// <method_to_show_board>
        public static void showBoard(char[] board)
        {
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("_________________");
            Console.WriteLine(" " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("_________________");
            Console.WriteLine(" " + board[7] + " | " + board[8] + " | " + board[9]);
        }
        /// <select_the_index_from_1_to_9_to_move>
        public static int GetUserMove(char[] board)
        {
            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("What is Your next move? (1-9):-");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(validCells, elements => elements == index) != 0 && isFreeSpace(board, index))
                    return index;
            }
             static bool isFreeSpace(char[] board, int index)
             {
                 return board[index] ==' ';
             }
        }
    }
}
