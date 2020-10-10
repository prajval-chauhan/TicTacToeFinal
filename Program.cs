using System;

namespace TicTacToeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame call = new TicTacToeGame();
            Console.WriteLine("Welcome to the Tic Tac Toe Program");
            char[] currentBoard = call.CreateBoard();
        }
    }
}
