using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс для работы с клеткой шахматной доски

    class clsCell
    {        
        private int i, j;

        public clsCell(int i, int j)
        {
           this.i = i;
           this.j = j;
        }

        //Перевод координат фигуры в шахматную нотацию
        public string Letter2Number
        {
            get { return (Horizontal)i + (j + 1).ToString(); }
        }
    }
}
