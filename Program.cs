using System;
using System.Linq;

namespace TicTacToeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame call = new TicTacToeGame();
            Console.WriteLine("Welcome to the Tic Tac Toe Game");
            char userInput = call.ZeroOrCross();
            char computerInput = call.ComputerInput(userInput);
            for (; ; )
            {
                char toss = call.Toss();
                int noOfTurns = 0;
                bool flag = false;
                char[] currentBoard = call.CreateBoard();
                switch (toss)
                {
                    case 'W':
                        for (; ; )
                        {
                            
                            currentBoard = Player(currentBoard, userInput);
                            flag = call.resultCheck(currentBoard);
                            noOfTurns += 1;
                            if (flag == true)
                            {
                                Console.WriteLine("You Won");
                                break;
                            }
                            if (noOfTurns == 9)
                            {
                                Console.WriteLine("Match Drawn");
                                break;
                            }
                            currentBoard = Computer(currentBoard, computerInput, userInput);
                            flag = call.resultCheck(currentBoard);
                            noOfTurns += 1;
                            if (flag == true)
                            {
                                Console.WriteLine("Take the L");
                                break;
                            }
                            if (noOfTurns == 9)
                            {
                                Console.WriteLine("Match Drawn");
                                break;
                            }
                        }
                        break;

                    case 'L':
                        for (; ; )
                        {
                            currentBoard = Computer(currentBoard, computerInput, userInput);
                            flag = call.resultCheck(currentBoard);
                            noOfTurns += 1;
                            if (flag == true)
                            {
                                Console.WriteLine("Take the L");
                                break;
                            }
                            if (noOfTurns == 9)
                            {
                                Console.WriteLine("Match Drawn");
                                break;
                            }
                            currentBoard = Player(currentBoard, userInput);
                            flag = call.resultCheck(currentBoard);
                            noOfTurns += 1;
                            if (flag == true)
                            {
                                Console.WriteLine("You Won");
                                break;
                            }
                            if (noOfTurns == 9)
                            {
                                Console.WriteLine("Match Drawn");
                                break;
                            }
                        }
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Would You like to play another game Y/N :");
                   char choice = Convert.ToChar(Console.ReadLine().ToLower());
                if (choice == 'n')
                    break;
            }
        }
        public static char[] Player(char[] board, char userInput)
        {
            TicTacToeGame call = new TicTacToeGame();
            Console.Clear();
            call.DispBoard(board);
            board = call.UserMove(board, userInput);
            Console.Clear();
            return board;
        }
        public static char[] Computer(char[] board, char computerInput, char userInput)
        {
            char[] boardCopy = new char[10];
            for (int i =0; i<board.Length; i++)
            {
                boardCopy[i] = board[i];
            }
            TicTacToeGame call = new TicTacToeGame();
            boardCopy = call.ComputerCheck(boardCopy, computerInput);
            if ((CompareBoard(board, boardCopy) == true))
            {
                boardCopy = call.PreventVictory(boardCopy, userInput);
                if (CompareBoard(board, boardCopy) == true)
                {
                    boardCopy = call.TakeTheCorner(boardCopy, computerInput);
                    if (CompareBoard(board, boardCopy) == true)
                    {
                        boardCopy = call.ComputerMove(boardCopy, computerInput);
                    }
                }
            }
            board = boardCopy;
            return board;
        }
        public static bool CompareBoard( char[] boardCopy, char[] board)
        {
            return boardCopy.SequenceEqual(board);
        }
    }
}
