using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeFinal
{
    class TicTacToeGame
    {
        /// <summary>
        /// Creates the board of size 10 with all the elements having null value.
        /// </summary>
        /// <returns></returns>
        public char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        /// <summary>
        /// Asks the user to choose the character he wants to play the game with. choices being 'O' or 'X'
        /// </summary>
        /// <returns></returns>
        public char ZeroOrCross()
        {
            char input;
            for (; ; )
            {
                Console.WriteLine("Enter the chracter, 'O' or 'X', you'd want to play with");
                input = Convert.ToChar(Console.ReadLine().ToUpper());
                if (input == 'O' || input == 'X')
                    break;
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
                Console.Clear();
            }
            return input;
        }
        /// <summary>
        /// Assigns the computer the character with which it is to play the game. If user chooses 'O' then computer plays 
        /// with 'X' and vice-versa.
        /// </summary>
        /// <param name="userInput">The user input.</param>
        /// <returns></returns>
        public char ComputerInput(char userInput)
        {
            char computerInput;
            if (userInput == 'X')
                computerInput = 'O';
            else
                computerInput = 'X';
            return computerInput;
        }
    }
}
