using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс ладья
    public class Rock: Figure 
    {
            
        public override void  Move(Move move)
        {
            throw new NotImplementedException();
        }
      
        public override bool IsCheckMove(Move move, Board  _board)
        {
            if (!base.IsCheckMove(move,_board)) return false;

            return true;
        }
        
        public Rock(FigureColor _color, char  symbol)
            : base(_color, symbol)
        { 
        }
        
    }
}
