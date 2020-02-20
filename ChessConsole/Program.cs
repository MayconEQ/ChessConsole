using System;
using Chessboard;
using ChessGame;

namespace ChessConsole {
    class Program {
        static void Main(string[] args) {
            ChessBoard board = new ChessBoard(8, 8);
            board.PutPiece(new Tower(Color.Black,board), new Position(0, 0));
            board.PutPiece(new King(Color.Black,board), new Position(0, 3));
            board.PutPiece(new Tower(Color.White,board), new Position(4, 7));
            board.PutPiece(new King(Color.Black, board), new Position(7, 4));

            Display.printChessBoard(board);
            Console.ReadLine();
        }
    }
}
