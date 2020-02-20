using Chessboard;
using System.Collections.Generic;
using System.Text;

namespace ChessGame {
    class Knight : Piece {

        public Knight(Color color, ChessBoard chessBoard) : base(color, chessBoard) {

        }
        public override string ToString() {
            return "♘";
        }

    }
}
