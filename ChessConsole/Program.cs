using System;
using Chessboard;

namespace ChessConsole {
    class Program {
        static void Main(string[] args) {
            ChessBoard pos = new ChessBoard(8, 8);
            Display.printChessBoard(pos);
            Console.ReadLine();
        }
    }
}
