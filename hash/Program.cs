using System;

namespace hash
{
    public class Program
    {
        static void Main(string[] args)
        {
            string winner;
            string[,] board = new string[3, 3];
            initBoard(board);

            Console.Write("Informe o nome do Jogador 1: ");
            string player1 = Console.ReadLine();
            Console.Clear();

            Console.Write("Informe o nome do Jogador 2: ");
            string player2 = Console.ReadLine();
            Console.Clear();

            viewBoard(board);

            do {
                board = validatePlay(board, player1, 1);
                viewBoard(board);

                if (getWinner(board, player1, player2))
                    return;

                board = validatePlay(board, player2, 2);
                viewBoard(board);
            }
            while (!getWinner(board, player1, player2));
        }


        static bool getWinner(string[,] board, string player1, string player2)
        {
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 2] != " ")
            {
                if (board[0, 0] == "O")
                    Console.Write(player1 + " é o VENCEDOR!!!");
                else
                    Console.Write(player2 + " é o VENCEDOR!!!");

                return true;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 2] != " ")
            {
                if (board[1, 0] == "O")
                    Console.Write(player1 + " é o VENCEDOR!!!");
                else
                    Console.Write(player2 + " é o VENCEDOR!!!");

                return true;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 2] != " ")
            {
                if (board[2, 0] == "O")
                    Console.Write(player1 + " é o VENCEDOR!!!");
                else
                    Console.Write(player2 + " é o VENCEDOR!!!");

                return true;
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] != " ")
            {
                if (board[0, 0] == "O")
                    Console.Write(player1 + " é o VENCEDOR!!!");
                else
                    Console.Write(player2 + " é o VENCEDOR!!!");

                return true;
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[2, 0] != " ")
            {
                if (board[0, 2] == "O")
                    Console.Write(player1 + " é o VENCEDOR!!!");
                else
                    Console.Write(player2 + " é o VENCEDOR!!!");

                return true;
            }
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[2, 0] != " ")
            {
                if (board[0, 0] == "O")
                    Console.Write(player1 + " é o VENCEDOR!!!");
                else
                    Console.Write(player2 + " é o VENCEDOR!!!");

                return true;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 2] != " ")
            {
                if (board[1, 0] == "O")
                    Console.Write(player1 + " é o VENCEDOR!!!");
                else
                    Console.Write(player2 + " é o VENCEDOR!!!");

                return true;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 2] != " ")
            {
                if (board[2, 0] == "O")
                    Console.Write(player1 + " é o VENCEDOR!!!");
                else
                    Console.Write(player2 + " é o VENCEDOR!!!");

                return true;
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[2, 1] != " ")
            {
                if (board[0, 1] == "O")
                    Console.Write(player1 + " é o VENCEDOR!!!");
                else
                    Console.Write(player2 + " é o VENCEDOR!!!");

                return true;
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[2, 2] != " ")
            {
                if (board[0, 2] == "O")
                    Console.Write(player1 + " é o VENCEDOR!!!");
                else
                    Console.Write(player2 + " é o VENCEDOR!!!");

                return true;
            }

            return false;
        }

        static string[,] validatePlay(string[,] board, string playerName, int player)
        {
            int positionColumn;
            int positionLine;

            do
            {
                positionLine = getPositionLine(playerName);
                positionColumn = getPositionColumn(playerName);
            }
            while (board[positionLine, positionColumn] != " ");

            if (player == 1)
                board[positionLine, positionColumn] = "O";
            else
                board[positionLine, positionColumn] = "X";

            return board;
        }

        static int getPositionColumn(string player)
        {
            int position = 3;
            while ((position < 0) || (position > 2)) {
                position = getPlayColumn(player);
            }

            return position;
        }
        static int getPositionLine(string player)
        {
            int position = 3;
            while ((position < 0) || (position > 2))
            {
                position = getPlayLine(player);
            }

            return position;
        }


        static int getPlayLine(string player)
        {
            Console.Write(player + " informe a linha: ");
            var position = int.Parse(Console.ReadLine()) - 1;
            return position;
        }
        static int getPlayColumn(string player) {
            Console.Write(player + " informe a coluna: ");
            var position = int.Parse(Console.ReadLine()) - 1;
            Console.Clear();
            return position;
        }


        static void viewBoard(string[,] board)
        {
            Console.WriteLine("  1|2|3");
            Console.WriteLine("1 " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("2 " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("3 " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
        }
        static string[,] initBoard(string[,] board)
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
