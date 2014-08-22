using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс пешка
    class Pawn: Figure 
    {
        public override string Cell()
        {
            throw new NotImplementedException();
        }

        public override void  Move(Move _move)
        {
            throw new NotImplementedException();
        }

        public override FigureColor Color()
        {
            throw new NotImplementedException();
        }

        public override string Symbol
        {
            get { return "П"; }
        }

        public override bool IsCheckMove(Move move)
        {
            throw new NotImplementedException();
        }
    }
}
