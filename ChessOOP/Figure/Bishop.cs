using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Слон
    class Bishop:Figure
    {
      
        public override void  Move(Move _move)
        {
            throw new NotImplementedException();
        }
        
        public override bool IsCheckMove(Move move, Board  objBoard)
        {
            Figure[,] board = objBoard.BRD;

            if (!base.IsCheckMove(move, objBoard )) return false;
            bool blnRet = false;
            if (Math.Abs(move.colTo - move.colFrom) != Math.Abs(move.rowTo - move.rowFrom))
            {
                if (!SilentMode )
                    Console.WriteLine("Так эта слон не ходит!");

                return blnRet;
            }

            int rowbegin, rowend;
            if (move.rowFrom < move.rowTo)
            {
                rowbegin = move.rowFrom;
                rowend = move.rowTo;
            }
            else
            {
                rowbegin = move.rowTo;
                rowend = move.rowFrom;
            }

            int colBegin = (move.colFrom > move.colTo) ? move.colTo : move.colFrom;
                        
            //Слон ходит по диагонали, соответственно проверяем диагональ
            for (int row = 0; row <= (rowend-rowbegin ); row++)
            {
                if ( (board[rowbegin + row , colBegin + row ]!= null) && ((move.rowFrom != row )
                    && move.colFrom!= (colBegin +row)))
                {
                    if (!SilentMode)
                        Console.WriteLine("Между началом хода слона " + move.From  + " и окончанием " 
                            + move.To + " содержится фигуры!");

                    return blnRet;
                }
            }

            blnRet = true;
            return blnRet;
            
        }

        public Bishop(FigureColor _color, char  symbol)
            : base(_color, symbol)
        { 
        }
    }
}
