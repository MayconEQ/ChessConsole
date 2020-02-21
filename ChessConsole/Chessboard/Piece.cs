using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard {
    class Piece {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MovimentCount { get; protected set; }
        public ChessBoard ChessBoard { get; protected set; }

        public Piece(Color color, ChessBoard chessBoard) {
            Position = null;
            Color = color;
            ChessBoard = chessBoard;
            MovimentCount = 0;
        }
        public void IncreaseMoviment() {
            MovimentCount++; 
        }
    }
}
