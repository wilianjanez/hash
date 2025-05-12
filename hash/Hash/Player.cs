using System;

namespace Hash
{
     class Player
    {
        public string name { get; set; }
        public bool firstPlayer { get; set; }

        public Player() { 
        
        }
        public Player(string name)
        {
            this.name = name;
        }

        public string[,] validatePlay(string[,] board, Player player)
        {
            int positionColumn;
            int positionLine;

            do
            {
                positionLine = setPositionLine(player);
                positionColumn = setPositionColumn(player);
            }
            while (board[positionLine, positionColumn] != " ");

            if (player.firstPlayer)
                board[positionLine, positionColumn] = "O";
            else
                board[positionLine, positionColumn] = "X";

            return board;
        }
        static int setPositionColumn(Player player)
        {
            int position = 3;
            while ((position < 0) || (position > 2))
            {
                position = setPlayColumn(player);
            }

            return position;
        }
        static int setPositionLine(Player player)
        {
            int position = 3;
            while ((position < 0) || (position > 2))
            {
                position = setPlayLine(player);
            }

            return position;
        }
        static int setPlayLine(Player player)
        {
            Console.Write($"{player.name} informe a linha: ");
            var position = int.Parse(Console.ReadLine()) - 1;
            return position;
        }
        static int setPlayColumn(Player player)
        {
            Console.Write($"{player.name} informe a coluna: ");
            var position = int.Parse(Console.ReadLine()) - 1;
            Console.Clear();
            return position;
        }
        public bool getWinner(string[,] board, Player player1, Player player2)
        {
            var linesToCheck = new (int, int, int, int, int, int)[]
            {
                // Linhas
                (0,0, 0,1, 0,2),
                (1,0, 1,1, 1,2),
                (2,0, 2,1, 2,2),
                // Colunas
                (0,0, 1,0, 2,0),
                (0,1, 1,1, 2,1),
                (0,2, 1,2, 2,2),
                // Diagonais
                (0,0, 1,1, 2,2),
                (0,2, 1,1, 2,0)
            };

            foreach (var (r1, c1, r2, c2, r3, c3) in linesToCheck)
            {
                string a = board[r1, c1], b = board[r2, c2], c = board[r3, c3];

                if (a == b && b == c && a != " ")
                {
                    string winnerName = (a == "O") ? player1.name : player2.name;
                    Console.WriteLine($"{winnerName} é o VENCEDOR!!!");
                    return true;
                }
            }

            if (endGame(board))
            {
                Console.Write($"Ninguem venceu!");
                return true;
            }

            return false;
        }
        public bool endGame(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
                for (int j = 0; j < board.GetLength(1); j++)
                    if (board[i, j] == " ")
                        return false;

            return true;
        }
    }
}
