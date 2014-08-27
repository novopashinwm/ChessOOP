using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс ферзь
    class Queen: Figure
    {
        
     
        public Queen(FigureColor _color, char  symbol)
            : base(_color, symbol)
        { 
        }
        
        public override bool IsCheckMove(Move move, Board _board)
        {

            if (!base.IsCheckMove(move, _board )) return false;

            return true;
        }
    }
}
