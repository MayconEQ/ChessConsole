using System;
using Chessboard;
using ChessGame;

namespace ChessConsole {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            try {
                ChessBoard board = new ChessBoard(8, 8);
                board.PutPiece(new Rooks(Color.Black, board), new Position(0, 0));
                board.PutPiece(new Knight(Color.Black, board), new Position(0, 1));
                board.PutPiece(new Bishop(Color.White, board), new Position(0, 2));
                board.PutPiece(new King(Color.Black, board), new Position(0, 3));
                board.PutPiece(new Queen(Color.White, board), new Position(0, 4));
                board.PutPiece(new Bishop(Color.Black, board), new Position(0, 5));
                board.PutPiece(new Knight(Color.White, board), new Position(0, 6));
                board.PutPiece(new Rooks(Color.Black, board), new Position(0, 7));
                board.PutPiece(new Pawn(Color.White, board), new Position(1, 0));
                board.PutPiece(new Pawn(Color.White, board), new Position(1, 1));
                board.PutPiece(new Pawn(Color.White, board), new Position(1, 2));
                board.PutPiece(new Pawn(Color.Black, board), new Position(1, 3));

                Display.PrintChessBoard(board);
                Console.ReadLine();
            } catch(ChessboardException e) {
                Console.WriteLine(e.Message);
            } 
        }
    }
}
