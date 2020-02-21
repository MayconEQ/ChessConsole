using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard {
    class ChessboardException: ApplicationException {
        public ChessboardException(string message) : base(message) { }
    }
}
