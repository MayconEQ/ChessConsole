using System;
using System.Collections.Generic;
using System.Text;
using Chessboard;

namespace ChessConsole {
    class Display {
        public static void PrintChessBoard(ChessBoard board) {
            for (int i = 0; i < board.Rows; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.Cols; j++) {
                    if (board.Piece(i, j) == null) {
                        Console.Write("\u25A1");
                    } else {
                        PrintPiece(board.Piece(i, j));
                        
                    }

                }
                Console.WriteLine();

            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece) {
            if (piece.Color == Color.White) {
                Console.Write(piece);
            } else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
