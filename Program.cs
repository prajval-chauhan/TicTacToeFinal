using System;

namespace TicTacToeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = false;
            int noOfTurns = 0;
            TicTacToeGame call = new TicTacToeGame(); // this object call is used to call the functions of class TicTacToeGmae
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
                        currentBoard = call.UserMove(currentBoard, userInput);
                        call.DispBoard(currentBoard);
                        noOfTurns = noOfTurns + 1;
                        if (noOfTurns == 9)
                        {
                            Console.WriteLine("Match Drawn");
                            break;
                        }
                        result = call.resultCheck(currentBoard);
                        if (result == true)
                        {
                            Console.WriteLine("You Won");
                            break;
                        }
                        currentBoard = call.ComputerCheck(currentBoard, computerInput);
                        if (call.resultCheck(currentBoard) == false)
                            currentBoard = call.PreventVictory(currentBoard, userInput);
                        if (call.resultCheck(currentBoard) == false)
                            currentBoard = call.ComputerMove(currentBoard, computerInput);
                        call.DispBoard(currentBoard);
                        noOfTurns = noOfTurns + 1;
                        if (noOfTurns == 9)
                        {
                            Console.WriteLine("Match Drawn");
                            break;
                        }
                        result = call.resultCheck(currentBoard);
                        if (result == true)
                        {
                            Console.WriteLine("Take the L");
                            break;
                        }
                        result = call.resultCheck(currentBoard);
                        Console.Clear();
                    }
                    break;
                case 'L':
                    for (; ; )
                    {
                        currentBoard = call.ComputerCheck(currentBoard, computerInput);
                        if (call.resultCheck(currentBoard) == false)
                            currentBoard = call.PreventVictory(currentBoard, userInput);
                        if (call.resultCheck(currentBoard) == false)
                            currentBoard = call.ComputerMove(currentBoard, computerInput);
                        call.DispBoard(currentBoard);
                        noOfTurns = noOfTurns + 1;
                        if (noOfTurns == 9)
                        {
                            Console.WriteLine("Match Drawn");
                            break;
                        }
                        result = call.resultCheck(currentBoard);
                        if (result == true)
                        {
                            Console.WriteLine("Take the L");
                            break;
                        }
                        currentBoard = call.UserMove(currentBoard, userInput);
                        call.DispBoard(currentBoard);
                        noOfTurns = noOfTurns + 1;
                        if (noOfTurns == 9)
                        {
                            Console.WriteLine("Match Drawn");
                            break;
                        }
                        result = call.resultCheck(currentBoard);
                        if (result == true)
                        {
                            Console.WriteLine("You Won");
                            break;
                        }
                        Console.Clear();
                    }
                    break;

            }

        }
/*        public char[] ComputerTurn(char [] currentBoard, char computerInput)
        {
            TicTacToeGame call = new TicTacToeGame();
            currentBoard = call.ComputerMove(currentBoard, computerInput);
            call.DispBoard(currentBoard);
            return (currentBoard);
        }

    public char[] UserTurn(char[] currentBoard, char userInput)
        {
            TicTacToeGame call = new TicTacToeGame();
            currentBoard = call.UserMove(currentBoard, userInput);
            call.DispBoard(currentBoard);
            return (currentBoard);
        }*/
    }
}
