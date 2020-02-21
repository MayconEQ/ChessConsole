using System;
using System.Collections.Generic;
using System.Text;
using Chessboard;

namespace ChessGame {
    class ChessMatch {
        public ChessBoard Board { get; set; }
        public int Phase { get; set; }
        public Color ActualPlayer { get; set; }
        public bool Finished { get; set; }

        public ChessMatch() {
            Board = new ChessBoard(8, 8);
            Phase = 1;
            ActualPlayer = Color.White;
            PutPieces();
            Finished = false;
        }
        public void PlayMovement(Position from, Position to) {
            Piece p = Board.OffPiece(from);
            p.IncreaseMoviment();
            Piece capturedPiece = Board.OffPiece(to);
            Board.PutPiece(p, to);
        }
        private void PutPieces() {
            //white pieces
            Board.PutPiece(new Rooks(Color.White, Board), new PositionChess('a', 1).ToPosition());
            Board.PutPiece(new Knight(Color.White, Board), new PositionChess('b', 1).ToPosition());
            Board.PutPiece(new Bishop(Color.White, Board), new PositionChess('c', 1).ToPosition());
            Board.PutPiece(new King(Color.White, Board), new PositionChess('d', 1).ToPosition());
            Board.PutPiece(new Queen(Color.White, Board), new PositionChess('e', 1).ToPosition());
            Board.PutPiece(new Bishop(Color.White, Board), new PositionChess('f', 1).ToPosition());
            Board.PutPiece(new Knight(Color.White, Board), new PositionChess('g', 1).ToPosition());
            Board.PutPiece(new Rooks(Color.White, Board), new PositionChess('h', 1).ToPosition());
            Board.PutPiece(new Pawn(Color.White, Board), new PositionChess('a', 2).ToPosition());
            Board.PutPiece(new Pawn(Color.White, Board), new PositionChess('b', 2).ToPosition());
            Board.PutPiece(new Pawn(Color.White, Board), new PositionChess('c', 2).ToPosition());
            Board.PutPiece(new Pawn(Color.White, Board), new PositionChess('d', 2).ToPosition());
            Board.PutPiece(new Pawn(Color.White, Board), new PositionChess('e', 2).ToPosition());
            Board.PutPiece(new Pawn(Color.White, Board), new PositionChess('f', 2).ToPosition());
            Board.PutPiece(new Pawn(Color.White, Board), new PositionChess('g', 2).ToPosition());
            Board.PutPiece(new Pawn(Color.White, Board), new PositionChess('h', 2).ToPosition());
            //black pieces
            Board.PutPiece(new Rooks(Color.Black, Board), new PositionChess('a', 8).ToPosition());
            Board.PutPiece(new Knight(Color.Black, Board), new PositionChess('b', 8).ToPosition());
            Board.PutPiece(new Bishop(Color.Black, Board), new PositionChess('c', 8).ToPosition());
            Board.PutPiece(new King(Color.Black, Board), new PositionChess('e', 8).ToPosition());
            Board.PutPiece(new Queen(Color.Black, Board), new PositionChess('d', 8).ToPosition());
            Board.PutPiece(new Bishop(Color.Black, Board), new PositionChess('f', 8).ToPosition());
            Board.PutPiece(new Knight(Color.Black, Board), new PositionChess('g', 8).ToPosition());
            Board.PutPiece(new Rooks(Color.Black, Board), new PositionChess('h', 8).ToPosition());
            Board.PutPiece(new Pawn(Color.Black, Board), new PositionChess('a', 7).ToPosition());
            Board.PutPiece(new Pawn(Color.Black, Board), new PositionChess('b', 7).ToPosition());
            Board.PutPiece(new Pawn(Color.Black, Board), new PositionChess('c', 7).ToPosition());
            Board.PutPiece(new Pawn(Color.Black, Board), new PositionChess('d', 7).ToPosition());
            Board.PutPiece(new Pawn(Color.Black, Board), new PositionChess('e', 7).ToPosition());
            Board.PutPiece(new Pawn(Color.Black, Board), new PositionChess('f', 7).ToPosition());
            Board.PutPiece(new Pawn(Color.Black, Board), new PositionChess('g', 7).ToPosition());
            Board.PutPiece(new Pawn(Color.Black, Board), new PositionChess('h', 7).ToPosition());

        }
    }
}
