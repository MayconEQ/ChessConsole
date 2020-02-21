using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard {
    class ChessBoard {
        public int Rows { get; set; }
        public int Cols { get; set; }
        private Piece[,] Pieces;

        public ChessBoard(int rows, int cols) {
            Rows = rows;
            Cols = cols;
            Pieces = new Piece[rows, cols];
        }
        public Piece Piece(int row, int col) {
            return Pieces[row, col];
        }
        public Piece Piece(Position pos) {
            return Pieces[pos.Row, pos.Col];
        }
        public void ValidPosition(Position pos) {
            if (pos.Row < 0 || pos.Row >= Rows || pos.Col < 0 || pos.Col >= Cols) {
                throw new ChessboardException("Invalid Position!");
            }
        }
        public bool ExistsPiece(Position pos) {
            ValidPosition(pos);
            return Piece(pos) != null;
        }
        public void PutPiece(Piece p, Position pos) {
            if (ExistsPiece(pos)) {
                throw new ChessboardException("There is a piece on there!");
            }
            Pieces[pos.Row, pos.Col] = p;
            p.Position = pos;
        }
        public Piece OffPiece( Position pos) {
            if (!ExistsPiece(pos)) {
                return null;
            }
            Piece aux = Piece(pos);
            aux.Position = null;
            Pieces[pos.Row, pos.Col] = null;
            return aux;
        }
        

    }

}
