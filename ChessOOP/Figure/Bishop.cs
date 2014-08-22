using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Слон
    class Bishop:Figure
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

        public override string Symbol()
        {
            return "C";
        }

        public override bool IsCheckMove(Move move)
        {
            throw new NotImplementedException();
        }
    }
}
