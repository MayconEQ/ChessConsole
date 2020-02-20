using Chessboard;
using System.Collections.Generic;
using System.Text;

namespace ChessGame {
    class Pawn : Piece {

        public Pawn(Color color, ChessBoard chessBoard) : base(color, chessBoard) {

        }
        public override string ToString() {
            return "♙";
        }

    }
}
