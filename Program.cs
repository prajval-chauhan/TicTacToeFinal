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
                        Player(currentBoard, userInput);
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
                        Computer(currentBoard, computerInput, userInput);
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
                        Computer(currentBoard, computerInput, userInput);
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
                        Player(currentBoard, userInput);
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
            char[] boardCopy = board;
            TicTacToeGame call = new TicTacToeGame();
            boardCopy = call.ComputerCheck(boardCopy, computerInput);
            if (boardCopy == board)
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
