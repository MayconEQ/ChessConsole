using System;
using Chessboard;
using ChessGame;

namespace ChessConsole {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            ChessBoard board = new ChessBoard(8, 8);
            board.PutPiece(new Rooks(Color.Black,board), new Position(0, 0));
            board.PutPiece(new Knight(Color.Black,board), new Position(0, 1));
            board.PutPiece(new Bishop(Color.White,board), new Position(0, 2));
            board.PutPiece(new King(Color.Black, board), new Position(0, 3));
            board.PutPiece(new Queen(Color.White, board), new Position(0, 4));
            board.PutPiece(new Bishop(Color.Black, board), new Position(0, 5));
            board.PutPiece(new Knight(Color.White, board), new Position(0, 6));
            board.PutPiece(new Rooks(Color.Black, board), new Position(0, 7));

            Display.printChessBoard(board);
            Console.ReadLine();
        }
    }
}
