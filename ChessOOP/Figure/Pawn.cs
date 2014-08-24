using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс пешка
    class Pawn: Figure 
    {
        

        public override void  Move(Move _move)
        {
            throw new NotImplementedException();
        }

        public override void SetCell(int i, int j)
        {
            base.SetCell(i, j);
        }
        
        public override bool IsCheckMove(Move move)
        {
            throw new NotImplementedException();
        }

        public Pawn(FigureColor _color, string symbol, int i , int j) 
            :base (_color , symbol , i,j )
        {
           
        }
    }
}
