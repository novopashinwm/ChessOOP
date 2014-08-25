using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Слон
    class Bishop:Figure
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

        public Bishop(FigureColor _color, string symbol, int i, int j)
            : base(_color, symbol, i, j)
        { 
        }
    }
}
