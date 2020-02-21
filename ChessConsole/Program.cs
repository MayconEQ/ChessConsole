using System;
using Chessboard;
using ChessGame;

namespace ChessConsole {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            try { 
                //criar tabuleiro
                ChessMatch match = new ChessMatch();
                while (!match.Finished) {
                    Console.Clear();
                    Display.PrintChessBoard(match.Board);
                    //inicia movimentação
                    Console.Write("From: ");
                    Position from = Display.GetPositionChess().ToPosition();
                    Console.Write("To: ");
                    Position to = Display.GetPositionChess().ToPosition();
                    match.PlayMovement(from, to);
                }
                Console.ReadLine();
            } catch(ChessboardException e) {
                Console.WriteLine(e.Message);
            } 
        }
    }
}
