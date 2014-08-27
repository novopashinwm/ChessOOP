using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Король
    class King:Figure
    {
       
        public override void  Move(Move _move)
        {
            throw new NotImplementedException();
        }
                        
        public override bool IsCheckMove(Move move, Board _board)
        {
            if (!base.IsCheckMove(move,_board)) return false;

            return true;
        }

        public King(FigureColor _color, char  symbol)
            : base(_color, symbol)
        { 
        }
    }
}
