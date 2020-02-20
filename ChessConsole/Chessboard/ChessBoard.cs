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
            Pieces = new Piece[rows,cols];
        }
    }

}
