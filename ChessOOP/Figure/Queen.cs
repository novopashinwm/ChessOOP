using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс ферзь
    class Queen: Figure
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
            get { return "Ф" ; }
        }

        public override bool IsCheckMove(Move move)
        {
            throw new NotImplementedException();
        }
    }
}
