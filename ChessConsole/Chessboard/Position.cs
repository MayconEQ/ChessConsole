using System;
using System.Collections.Generic;
using System.Text;

namespace Chessboard {
    class Position {

        public int Row { get; set; }
        public int Col { get; set; }

        public Position(int row, int col) {
            Row = row;
            Col = col;
        }

        public override string ToString() {
            return Row
                +", "
                +Col;
        }
    }
}
