using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс фигуры
    public    class Figure
    {
        private FigureColor _color;         
        private  string _symbol;
        private   clsCell objCell;
        
        //Цвет
         public FigureColor Color
         {
             get { return _color; }
         }

         public virtual void SetCell(int i, int j)
         {
             objCell = new clsCell(i, j);
         }
                    
        //Символ
        public string Symbol { get { return _symbol; } }
        //Клетка на которой находится фигура
        
        //Шаг
        public virtual void Move(Move _move)
        { 
            
        }
        //Проверка хода
        public virtual bool IsCheckMove(Move _move)
        {
            return true;
        }

        //Установка фигуры на определенную клетку
        //public abstract void SetFigure();
        public Figure(FigureColor fc, string symbol, int i, int j)
        {
            this._color = fc;
            this._symbol = symbol;
            this.SetCell(i, j);
        }
    }
}
