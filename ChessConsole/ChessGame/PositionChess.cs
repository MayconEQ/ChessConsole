using System;
using System.Collections.Generic;
using System.Text;
using Chessboard;

namespace ChessGame {
    class PositionChess {
        public char Col { get; set; }
        public int Row { get; set; }
        public PositionChess(char col, int row) {
            Col = col;
            Row = row;
        }
        public Position ToPosition() {
            return new Position(8 - Row, Col - 'a');
        }
        public override string ToString() {
            return Col + Row.ToString();
        }
    }
}
