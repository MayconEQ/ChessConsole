using Chessboard;
using System.Collections.Generic;
using System.Text;

namespace ChessGame {
    class Rooks : Piece {

        public Rooks(Color color, ChessBoard chessBoard) : base(color, chessBoard) {

        }
        public override string ToString() {
            return "♖";
        }

    }
}
