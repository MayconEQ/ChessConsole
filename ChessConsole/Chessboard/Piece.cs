using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard {
    class Piece {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovementCount { get; protected set; }
        public ChessBoard ChessBoard { get; protected set; }

        public Piece(Position position, Color color, ChessBoard chessBoard) {
            Position = position;
            Color = color;
            ChessBoard = chessBoard;
            MovementCount = 0;
        }
    }
}
