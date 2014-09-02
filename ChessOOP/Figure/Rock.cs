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

            if ((move.rowFrom != move.rowTo) && (move.colTo != move.colFrom))
            {
                if (!SilentMode)
                    Console.WriteLine("Так ладья не ходит!");

                return false;
            }

            Figure[,] board = _board.BRD;
            bool blnRet = false;
            int rowBegin = Math.Min(move.rowFrom, move.rowTo);
            int rowEnd = Math.Max (move.rowFrom, move.rowTo);
            int colBegin = Math.Min (move.colFrom, move.colTo);
            int colEnd = Math.Max (move.colFrom, move.colTo) ;
            
            #region Проверка хода по горизонтали
            if (move.rowTo == move.rowFrom)
            {
                for (int col = colBegin; col <= (colEnd - colBegin); col++)
                {
                    if ((board[rowBegin, colBegin + col] != null) && (move.colFrom != (colBegin + col)))
                    {
                        if (!SilentMode)
                            Console.WriteLine("Между началом хода ладьи " + move.From + " и окончанием хода "
                                + move.To + " содержится фигуры!");
                        return blnRet;
                    }
                }
            }
            #endregion
            
            #region Проверка хода по вертикали
            if (move.colTo == move.colFrom)
            {
                for (int row = rowBegin; row <= (rowEnd - rowBegin); row++)
                {
                    if ((board[rowBegin + row, colBegin] != null) && (move.rowFrom != row))
                    {
                        if (!SilentMode)
                            Console.WriteLine("Между началом хода ладьи " + move.From + " и окончанием хода "
                                + move.To + " содержится фигуры!");

                        return blnRet;
                    }
                }
            }
            #endregion
            
            return true;
        }
        
        public Rock(FigureColor _color, char  symbol)
            : base(_color, symbol)
        { 
        }
        
    }
}
