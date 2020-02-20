using System;
using System.Collections.Generic;
using System.Text;
using Chessboard;

namespace ChessConsole {
    class Display {
        public static void printChessBoard(ChessBoard board) {
            for (int i = 0; i < board.Rows; i++) {
                for (int j = 0; j < board.Cols; j++) {
                    if (board.Piece(i, j) == null) {
                        Console.Write("- ");
                    } else {
                        Console.Write(board.Piece(i, j) + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
