using Chessboard;
using System.Collections.Generic;
using System.Text;

namespace ChessGame {
    class Queen : Piece {

        public Queen(Color color, ChessBoard chessBoard) : base(color, chessBoard) {

        }
        public override string ToString() {
            return "♕";
        }

    }
}
