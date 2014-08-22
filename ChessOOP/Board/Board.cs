using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс доска
    public class Board
    {
        private Figure  [,] _board  = new Figure [8,8];

        public Figure  [,] MyBoard 
        {
            get {return _board ; }
        }

        //Расставить фигуры
        public void PlaceFigures()
        { 
           //Ставим пешки
            for (int i = 0; i < 8; i++)
            { 
                
            }
        }

        //Выбрать фигуру
        public Figure SelectFigure()
        {
            throw new NotImplementedException();
        }
    }
}
