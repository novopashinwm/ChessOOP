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
                        
        public override bool IsCheckMove(Move move)
        {
            if (!base.IsCheckMove(move)) return false;

            return true;
        }

        public King(FigureColor _color, char  symbol, int i, int j)
            : base(_color, symbol, i, j)
        { 
        }
    }
}
