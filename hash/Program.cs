using System;
using Hash;

namespace hash
{
    public class Program
    {
        static void Main(string[] args)
        {
            Board classBoard = new Board();
            Player player = new Player();

            Player player1 = new Player();
            Player player2 = new Player();

            string[,] board = new string[3, 3];
            classBoard.initBoard(board);

            Console.Write("Informe o nome do Jogador 1: ");
            player1.name = Console.ReadLine();
            player1.firstPlayer = true;
            Console.Clear();

            Console.Write("Informe o nome do Jogador 2: ");
            player2.name = Console.ReadLine();
            player2.firstPlayer = false;
            Console.Clear();

            classBoard.viewBoard(board);

            do {
                board = player.validatePlay(board, player1);
                classBoard.viewBoard(board);

                if (player.getWinner(board, player1, player2))
                    return;

                board = player.validatePlay(board, player2);
                classBoard.viewBoard(board);
            }
            while (!player.getWinner(board, player1, player2));
        }
    }
}
