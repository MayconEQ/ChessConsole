using Chessboard;
using System.Collections.Generic;
using System.Text;

namespace ChessGame {
    class King : Piece {

        public King(Color color, ChessBoard chessBoard) : base(color, chessBoard) {

        }
        public override string ToString() {
            return "K";
        }

    }
}