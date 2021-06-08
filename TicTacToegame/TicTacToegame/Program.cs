using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToegame
{
    class Program
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public enum Player { USER, COMPUTER };
        /// Head and Tails, Who start First
        public static Player getWhoStartFirst()
        {
            int toss = getOneFromRandomChoice(2);
            return (toss == HEAD) ? Player.USER : Player.COMPUTER;
        }
        public static int getOneFromRandomChoice(int choices)
        {
            Random objRandom = new Random();
            return (int)(objRandom.Next() * 10) % choices;
        }
        static bool isWinner(char[] board, char ch)
        {
            return ((board[1] == ch && board[2] == ch && board[3] == ch) ||     //across the top
                   (board[4] == ch && board[5] == ch && board[6] == ch) ||     //across the middle
                   (board[7] == ch && board[8] == ch && board[9] == ch) ||     //across the top
                   (board[1] == ch && board[4] == ch && board[7] == ch) ||     //across the left                                                    
                   (board[2] == ch && board[5] == ch && board[8] == ch) ||     //across the middle                                                                     
                   (board[3] == ch && board[6] == ch && board[9] == ch) ||     //across the right 
                   (board[1] == ch && board[5] == ch && board[9] == ch) ||     //across the top left diagonal
                   (board[7] == ch && board[5] == ch && board[3] == ch));      //across the bottom left diagonal
        }
        ///get computer move UC8-11
        private static int getComputerMove(char[] board, char computerLetter, char userLetter)
        {
            int winnigMove = getWinningMove(board, computerLetter);
            if (winnigMove != 0) return winnigMove;
            int userWinnigMove = getWinningMove(board, userLetter);
            if (userWinnigMove != 0) return userWinnigMove;
            int[] cornerMove = { 1, 3, 7, 9 };
            int computerMove = getRandomMoveFromList(board, cornerMove);
            if (computerMove != 0) return computerMove;
            if (isFreeSpace(board, 5)) return 5;  // center Move
            int[] sideMove = { 2, 4, 6, 8 };
            computerMove = getRandomMoveFromList(board, sideMove);
            if (computerMove != 0) return computerMove;
            return 0;
        }
        private static int getRandomMoveFromList(char[] board, int[] moves)
        {
            for (int index = 0; index < moves.Length; index++)
            {
                if (isFreeSpace(board, moves[index])) return moves[index];
            }
            return 0;
        }

        ///winng move
        private static int getWinningMove(char[] board, char letter)
        {
            for (int index = 1; index < board.Length; index++)
            {
                char[] copyOfBoard = getCopyOfBoard(board);
                if (isFreeSpace(copyOfBoard, index))
                {
                    makeMove(copyOfBoard, index, letter);
                    if (isWinner(copyOfBoard, letter))
                        return index;
                }
            }
            return 0;
        }
        public static void makeMove(char[] board, int index, char letter)
        {
            bool spaceFree = isFreeSpace(board, index);
            if (spaceFree) board[index] = letter;
        }
        public static bool isFreeSpace(char[] board, int index)
        {
            return board[index] == ' ';
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

        }
     
        public static char[] getCopyOfBoard(char[] board)
        {
            char[] boardCopy = new char[10];
            Array.Copy(board, boardCopy, board.Length);
            return boardCopy;
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
            int userMove = GetUserMove(board);
            makeMove(board, userMove, choose);
            /// who statrt first
            Player player = getWhoStartFirst();
            /// change the turn
            char userLetter = TicTacToe.ChooseUserLetter();
            Console.WriteLine("check if won" + isWinner(board,userLetter)); ///change the turn
            ///computerLetter
            char computerLetter = TicTacToe.chooseComputerChar(userLetter);
            Console.WriteLine("check if won"+isWinner(board,userLetter));
            ///computermove
            int computeMoves = getComputerMove(board, computerLetter, userLetter);
            Console.ReadKey();

        }

    }

}   
