using System;
using Chessboard;
using ChessGame;

namespace ChessConsole {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            PositionChess pos = new PositionChess('h',7);
            Console.WriteLine(pos.ToPosition());
            Console.WriteLine(pos);
        }
    }
}
