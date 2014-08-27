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
                
        public override bool IsCheckMove(Move move, Board objBrd )
        {
            Figure[,] _board = objBrd.BRD;
            if (!base.IsCheckMove(move, objBrd)) return false;
            //Проверяем, что на конечной клетке хода нет нашей фигуры                        
            //Если ходим с клетки 2 - допустим a2, то можно передвинуться на одну клетку или сразу на 2 клетки
            bool blnRet = false;
            if (Math.Abs(move.colFrom - move.colTo) > 1)
            {
                Console.WriteLine("Пешка не может ходить через 2 столбца");
                return blnRet;
            }
            
            if ((move.colFrom != move.colTo) && (objBrd.To == null) )
            {
                Console.WriteLine("Ошибочный ход на клетку " + move.To);
                return blnRet;
            }

            //Проверяем ход сначала на 2 клетки
            if ((move.colTo == move.colFrom)  &&
                (
                //Белые не могут дальше 1 клетки
                ((Color == FigureColor.White ) && ((move.rowTo - move.rowFrom) > 1) && move.rowFrom != 1)
                ||
                //Черные не могут двигаться дальше 1 клетки
                ((Color == FigureColor.Black) && ((move.rowFrom - move.rowTo) > 1) && move.rowFrom != 6)
                ||
                //С начальной позиции белые не могут двигаться дальше 2 шагов вперед
                ((Color == FigureColor.White) && ((move.rowTo - move.rowFrom) > 2) && move.rowFrom == 1)
                ||
                //С начальной позиции черные не могут двигаться далдьше 2 шагов вперед
                ((Color == FigureColor.Black) && ((move.rowFrom - move.rowTo) > 2) && move.rowFrom == 6)
                ))
                return blnRet;
            return true;
        }

        public Pawn(FigureColor _color, char  symbol) 
            :base (_color , symbol)
        {
           
        }
    }
}
