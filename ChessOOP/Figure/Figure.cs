using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс фигуры
    public abstract class Figure
    {
        protected string _symbol;
        //Цвет
        public abstract FigureColor Color();
        //Символ
        public abstract string Symbol();
        //Клетка на которой находится фигура
        public abstract string Cell();
        //Шаг
        public abstract bool Move();
        //Проверка хода
        public abstract bool IsCheckMove(Move _move);
    }
}
