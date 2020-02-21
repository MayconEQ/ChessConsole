using Chessboard;
using System.Collections.Generic;
using System.Text;

namespace ChessGame {
    class Bishop : Piece {

        public Bishop(Color color, ChessBoard chessBoard) : base(color, chessBoard) {

        }
        public override string ToString() {
            
            return "♗ ";
        }

    }
}
