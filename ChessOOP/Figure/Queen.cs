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
                        
            //Сначала проверяем ход ферзя, как слона
            Bishop objBishop = new Bishop(this.Color, this.Symbol);
            objBishop.SilentMode = true;
            bool blnBishop = objBishop.IsCheckMove(move, _board);            

            //Потом делаем провеку хода как ладьи
            Rock objRock = new Rock(this.Color, this.Symbol);
            objRock.SilentMode = true;
            bool blnRock = objRock.IsCheckMove(move, _board);

            //Если обе проверки мы не прошли, значит ошибка
            if ((!blnBishop) && (!blnRock))
            {
                Console.WriteLine("Ошибочный ход!!!");
                return false;
            }

            return true;
        }
    }
}
