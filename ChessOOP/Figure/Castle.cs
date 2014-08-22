using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс ладья
    class Castle: Figure
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
            get { return "Л"; }
        }

        public override bool IsCheckMove(Move move)
        {
            throw new NotImplementedException();
        }

        
    }
}
