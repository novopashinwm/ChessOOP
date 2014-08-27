using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Конь
    class Knight: Figure 
    {
       
        public override void  Move(Move _move)
        {
            throw new NotImplementedException();
        }

        public override bool IsCheckMove(Move move, Board _board)
        {

            if (!base.IsCheckMove(move, _board)) return false;

            //Делаем проверку, что конь сходил буквой Г
            if (((Math.Abs(move.rowTo - move.rowFrom) == 1) && (Math.Abs(move.colTo - move.colFrom) == 2)) ||
                ((Math.Abs(move.colTo - move.colFrom) == 1) && (Math.Abs(move.rowTo - move.rowFrom) == 2))
                )
                return true;

            Console.WriteLine("Так конь не ходит!");
            return false ;
        }

        public Knight(FigureColor _color, char  symbol)
            : base(_color, symbol)
        { 
        }
    }
}
