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
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 2] != " ")
            {
                if (board[0, 0] == "O")
                    Console.Write($"{player1.name} é o VENCEDOR!!!");
                else
                    Console.Write($"{player2.name} é o VENCEDOR!!!");

                return true;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 2] != " ")
            {
                if (board[1, 0] == "O")
                    Console.Write($"{player1.name} é o VENCEDOR!!!");
                else
                    Console.Write($"{player2.name} é o VENCEDOR!!!");

                return true;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 2] != " ")
            {
                if (board[2, 0] == "O")
                    Console.Write($"{player1.name} é o VENCEDOR!!!");
                else
                    Console.Write($"{player2.name} é o VENCEDOR!!!");

                return true;
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] != " ")
            {
                if (board[0, 0] == "O")
                    Console.Write($"{player1.name} é o VENCEDOR!!!");
                else
                    Console.Write($"{player2.name} é o VENCEDOR!!!");

                return true;
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[2, 0] != " ")
            {
                if (board[0, 2] == "O")
                    Console.Write($"{player1.name} é o VENCEDOR!!!");
                else
                    Console.Write($"{player2.name} é o VENCEDOR!!!");

                return true;
            }
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[2, 0] != " ")
            {
                if (board[0, 0] == "O")
                    Console.Write($"{player1.name} é o VENCEDOR!!!");
                else
                    Console.Write($"{player2.name} é o VENCEDOR!!!");

                return true;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 2] != " ")
            {
                if (board[1, 0] == "O")
                    Console.Write($"{player1.name} é o VENCEDOR!!!");
                else
                    Console.Write($"{player2.name} é o VENCEDOR!!!");

                return true;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 2] != " ")
            {
                if (board[2, 0] == "O")
                    Console.Write($"{player1.name} é o VENCEDOR!!!");
                else
                    Console.Write($"{player2.name} é o VENCEDOR!!!");

                return true;
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[2, 1] != " ")
            {
                if (board[0, 1] == "O")
                    Console.Write($"{player1.name} é o VENCEDOR!!!");
                else
                    Console.Write($"{player2.name} é o VENCEDOR!!!");

                return true;
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[2, 2] != " ")
            {
                if (board[0, 2] == "O")
                    Console.Write($"{player1.name} é o VENCEDOR!!!");
                else
                    Console.Write($"{player2.name} é o VENCEDOR!!!");

                return true;
            }

            return false;
        }
    }
}
