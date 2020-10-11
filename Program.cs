using System;
using System.Linq;

namespace TicTacToeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame call = new TicTacToeGame();
            bool flag = false;
            int noOfTurns = 0;
            Console.WriteLine("Welcome to the Tic Tac Toe Program");
            char userInput = call.ZeroOrCross();
            char computerInput = call.ComputerInput(userInput);

            char toss = call.Toss();

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
                            Console.WriteLine("Computer Won");
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
                            Console.WriteLine("Computer Won");
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
        }
        public static char[] Player(char[] board, char userInput)
        {
            TicTacToeGame call = new TicTacToeGame();
            board = call.UserMove(board, userInput);
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
            Console.WriteLine("Current Board: \n");
            call.DispBoard(board);
            return board;
        }

        public static bool CompareBoard( char[] boardCopy, char[] board)
        {
            return boardCopy.SequenceEqual(board);
        }
    }
}
