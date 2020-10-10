using System;

namespace TicTacToeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame call = new TicTacToeGame(); // this object call is used to call the functions of class TicTacToeGmae
            Console.WriteLine("Welcome to the Tic Tac Toe Program");
            char userInput = call.ZeroOrCross();
            char computerInput = call.ComputerInput(userInput);

            char toss = call.Toss();

            char[] currentBoard = call.CreateBoard();

            switch(toss)
            {
                case 'W':
                    currentBoard = call.UserMove(currentBoard, userInput);
                    call.DispBoard(currentBoard);
                    currentBoard = call.ComputerMove(currentBoard, computerInput);
                    call.DispBoard(currentBoard);
                    Console.Clear();
                    break;
                case 'L':
                    currentBoard = call.ComputerMove(currentBoard, computerInput);
                    call.DispBoard(currentBoard);
                    currentBoard = call.UserMove(currentBoard, userInput);
                    call.DispBoard(currentBoard);
                    Console.Clear();
                    break;

            }
        }
    }
}
