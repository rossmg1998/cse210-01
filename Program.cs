// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!! - from Ross Gardner");

/* Tic-Tac-Toe
Author: Ross Gardner */

namespace Namespace {

    public static class Module {

        public static void main() {
            var player = next_player("");
            var board = create_board();
            while (!(has_winner(board) || is_a_draw(board))) {
                display_board(board);
                make_move(player, board);
                player = next_player(player);
            }
            display_board(board);
            Console.WriteLine("Good game. Thanks for playing!");
        }

        public static object create_board() {
            var board = new List<object>();
            foreach (var square in Enumerable.Range(0, 9)) {
                board.Append(square + 1);
            }
            return board;
        }

        public static void display_board(object board) {
            Console.WriteLine();
            Console.WriteLine("{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine("{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine("{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine();
        }

        public static bool is_a_draw(string board) {
            foreach (var square in Enumerable.Range(0, 9)) {
                if (board[square] != "x" && board[square] != "o") {
                    return false;
                }
            }
            return true;
        }

        public static bool has_winner(string board) {
            return board[0] == board[1] == board[2] || 
            board[3] == board[4] == board[5] || 
            board[6] == board[7] == board[8] || 
            board[0] == board[3] == board[6] || 
            board[1] == board[4] == board[7] || 
            board[2] == board[5] == board[8] || 
            board[0] == board[4] == board[8] || 
            board[2] == board[4] == board[6];
        }

        public static void make_move(string player, string board) {
            var square = Convert.ToInt32(input("{player}'s turn to choose a square (1-9): "));
            board[square - 1] = player;
        }

        public static string next_player(string current) {
            if (current == "" || current == "o") {
                return "x";
            } else {
                return "o";
            }
        }

        static Module() {
            main();
        }
    }
}