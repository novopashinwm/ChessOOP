using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс фигуры
    public    class Figure
    {
        private FigureColor _color;         
        private  char _symbol;
        public bool SilentMode { get; set; }     

        //Цвет
         public FigureColor Color
         {
             get { return _color; }
         }

                    
        //Символ
        public char  Symbol { get { return _symbol; } }
        //Клетка на которой находится фигура
        
        //Шаг
        public virtual void Move(Move _move)
        { 
            
        }
        

        public virtual bool IsCheckMove(Move _move, Board objBoard)
        {
          
            bool blnRet = false;

            #region Проверяем, что сейчас ход той фигуры, цвет которой указан
            if (objBoard.WhichMove != objBoard.From.Color)
            {
                if (objBoard.WhichMove == FigureColor.White)
                    Console.WriteLine("Сейчас ход белых!");
                else
                    Console.WriteLine("Сейчас ход черных!");

                return blnRet;
            }
            #endregion

            #region Проверяем, что клетка куда пойдет фигура не содержит фигуру того же цвета            
            if (objBoard.To != null)
            {
                if (objBoard.From.Color == objBoard.To.Color)
                {
                    Console.WriteLine("Фигура пошла на клетку с фигурой того же цвета!");
                    return blnRet;
                }
            }
            #endregion         
            return true;
        }

        //Установка фигуры на определенную клетку
        //public abstract void SetFigure();
        public Figure(FigureColor fc, char symbol )
        {
            this._color = fc;
            this._symbol = symbol;
            this.SilentMode = false;
        }
    }
}
