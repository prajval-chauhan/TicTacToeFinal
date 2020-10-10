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
        /// <summary>
        /// Displays the current board with user and computer moves.
        /// </summary>
        /// <param name="board">The board.</param>
        public void DispBoard(char[] board)
        {
            Console.WriteLine("---------------- \nCurrent Board\n----------------\n");
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("----------");
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("----------");
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
            Console.ReadKey();
        }

        /// <summary>
        /// Allows the user to input moves into desired locations on the board
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="userInput">The user input.</param>
        /// <returns></returns>
        public char[] UserMove(char[] board, char userInput)
        {
            for (; ; )
            {
                Console.WriteLine("Choose the position where you'd like to place {0}", userInput);
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > 0 && input <= 9 && board[input] ==' ')
                {
                    board[input] = userInput;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Move");
                    Console.ReadKey();
                    Console.Clear();
                    DispBoard(board);
                }
            }
            return board;
        }
        /// <summary>
        /// Computer generates a random number and if the board is free at that position then the computer makes its move
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="computerInput">The computer input.</param>
        /// <returns></returns>
        public char[] ComputerMove(char[] board, char computerInput)
        {
            Random randomNum = new Random();
            int input;
            for (; ; )
            {
                input = randomNum.Next(1, 10);
                if (input > 0 && input <= 9 && board[input] == ' ')
                {
                    board[input] = computerInput;
                    break;
                }

            }
            return board;
        }
        /// <summary>
        /// The toss decides who goes first.
        /// </summary>
        /// <returns></returns>
        public char Toss()
        {
            Random randomNum = new Random();
            Console.WriteLine("Enter '1' for heads and '0' for Tails");
            int input = Convert.ToInt32(Console.ReadLine());
            for (; ; )
            {
                if (input == 1 || input == 0)
                {
                    int Toss = randomNum.Next(0, 1);
                    if (Toss == input)
                    {
                        Console.WriteLine("You won the toss");
                        Console.ReadKey();
                        return 'W';
                    }
                    else
                    {
                        Console.WriteLine("Computer won the toss");
                        Console.ReadKey();
                        return 'L';
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
            }
            
        }
    }
}
