using System;

namespace TicTacToeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame call = new TicTacToeGame(); // this object call is used to call the functions of class TicTacToeGmae
            Console.WriteLine("Welcome to the Tic Tac Toe Program");
            char[] currentBoard = call.CreateBoard();
            char userInput = call.ZeroOrCross();
            char computerInput = call.ComputerInput(userInput);
            Console.Clear();
            call.DispBoard(currentBoard);
            currentBoard = call.UserMove(currentBoard, userInput);
            Console.Clear();
            call.DispBoard(currentBoard);
            currentBoard = call.ComputerMove(currentBoard, computerInput);
            Console.Clear();
            call.DispBoard(currentBoard);

        }
    }
}
