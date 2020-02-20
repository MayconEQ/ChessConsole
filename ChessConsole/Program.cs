using System;
using Chessboard;

namespace ChessConsole {
    class Program {
        static void Main(string[] args) {
            ChessBoard pos = new ChessBoard(3, 4);
            Console.WriteLine(pos);
        }
    }
}
