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
            int rowBegin, rowEnd, colBegin, colEnd;
            if (move.rowTo > move.rowFrom)
                { rowBegin = move.rowFrom;  rowEnd = move.rowTo; }
            else
                { rowBegin = move.rowTo; rowEnd = move.rowFrom;  }

            if (move.colTo > move.colFrom)
                { colBegin = move.colFrom;  colEnd = move.colTo; }
            else
                { colBegin = move.colTo; colEnd = move.colFrom; }

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
