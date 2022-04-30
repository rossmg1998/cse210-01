// See https://aka.ms/new-console-template for more information

/* Tic-Tac-Toe
Author: Ross Gardner */

namespace cse210_01 {

    public static class Module {

        static void Main() {
            var player = next_player("");
            List<string> board = create_board();
            while (!(has_winner(board) || is_a_draw(board))) {
                display_board(board);
                make_move(player, board);
                player = next_player(player);
            }
            display_board(board);
            Console.WriteLine("Good game. Thanks for playing!");
        }

        public static List<string> create_board() {
            var board = new List<string>();
            for (int i = 1; i < 10; i++)
            {
                board.Add(i.ToString());
            }
            return board;
        }

        public static void display_board(List<string> board) {
            Console.WriteLine();
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine();
        }

        public static bool is_a_draw(List<string> board) {
            int square = 0;
            for (int i = 0; i < 10; i++) {
                if (board[square] != "x" && board[square] != "o") {
                    return false;
                }
            }
            return true;
        }

        public static bool has_winner(List<string> board) {
            return (board[0] == board[1] && board[1] == board[2]) || 
            (board[3] == board[4] && board[4] == board[5]) || 
            (board[6] == board[7] && board[7] == board[8]) || 
            (board[0] == board[3] && board[3] == board[6]) || 
            (board[1] == board[4] && board[4] == board[7]) || 
            (board[2] == board[5] && board[5] == board[8]) || 
            (board[0] == board[4] && board[4] == board[8]) || 
            (board[2] == board[4] && board[4] == board[6]);
        }

        public static void make_move(string player, List<string> board) {
            Console.Write($"{player}'s turn to choose a square (1-9): ");
            string square = Console.ReadLine();

            board[Convert.ToInt32(square) - 1] = player;
            
        }

        public static string next_player(string current) {
            if (current == "" || current == "o") {
                return "x";
            } else {
                return "o";
            }
        }

        static Module() {
            Main();
        }
    }
}