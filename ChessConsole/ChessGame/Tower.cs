using Chessboard;
using System.Collections.Generic;
using System.Text;

namespace ChessGame {
    class Tower : Piece {

        public Tower(Color color, ChessBoard chessBoard) : base(color, chessBoard) {

        }
        public override string ToString() {
            return "T";
        }

    }
}
