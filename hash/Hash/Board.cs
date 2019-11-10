using System;
using System.Collections.Generic;
using System.Text;

namespace Hash
{
    class Board
    {
        public void viewBoard(string[,] board)
        {
            Console.WriteLine("  1 | 2 | 3");
            Console.WriteLine($"1 {board[0, 0]} | {board[0, 1]} | {board[0, 2]}");
            Console.WriteLine($"2 {board[1, 0]} | {board[1, 1]} | {board[1, 2]}");
            Console.WriteLine($"3 {board[2, 0]} | {board[2, 1]} | {board[2, 2]}");
        }
        public string[,] initBoard(string[,] board)
        {
            board[0, 0] = " ";
            board[0, 1] = " ";
            board[0, 2] = " ";
            board[1, 0] = " ";
            board[1, 1] = " ";
            board[1, 2] = " ";
            board[2, 0] = " ";
            board[2, 1] = " ";
            board[2, 2] = " ";

            return board;
        }
    }
}
