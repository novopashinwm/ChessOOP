using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Конь
    class Knight: Figure 
    {
        public override string Cell()
        {
            throw new NotImplementedException();
        }

        public override bool Move()
        {
            throw new NotImplementedException();
        }

        public override FigureColor Color()
        {
            throw new NotImplementedException();
        }

        public override string Symbol
        {
            get { return "К"; }
        }

        public override bool IsCheckMove(Move move)
        {
            throw new NotImplementedException();
        }
    }
}
