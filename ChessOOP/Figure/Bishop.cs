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
        
        public override bool IsCheckMove(Move Move, Board  objBoard)
        {
            Figure[,] board = objBoard.BRD;

            if (!base.IsCheckMove(Move, objBoard )) return false;
            bool blnRet = false;
            if (Math.Abs(Move.colTo - Move.colFrom) != Math.Abs(Move.rowTo - Move.rowFrom))
            {
                Console.WriteLine("Так слон не ходит!");
                return blnRet;
            }

            int begin, end;
            if (Move.rowFrom < Move.rowTo)
            {
                begin = Move.rowFrom;
                end = Move.rowTo;
            }
            else
            {
                begin = Move.rowTo;
                end = Move.rowFrom;
            }
            //Слон ходит по диагонали, соответственно проверяем диагональ
            for (int i = begin; i < end; i++)
            {
                if (board[i, i]!= null)
                {
                    Console.WriteLine("Между началом хода слона " + Move.From  + " и окончанием хода " 
                        + Move.To + " содержится фигуры!");
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
