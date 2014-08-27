using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    public  enum FigureColor { Black, White};

    public class  Move
    {
        public Move(string strMove)
        {
            string[] arrMove = strMove.Split(' ');
            //Если не правильная буква, то формируется Exception
            From = arrMove[0];
            To = arrMove[1];
            colFrom = (int)Enum.Parse(typeof(Horizontal), arrMove[0].Substring(0, 1).ToUpper());
            rowFrom = int.Parse(arrMove[0].Substring(1, 1)) - 1;
            colTo = (int)Enum.Parse(typeof(Horizontal), arrMove[1].Substring(0, 1).ToUpper());
            rowTo = int.Parse(arrMove[1].Substring(1, 1)) - 1;
        }
               
        //public Move() :this ("a1 a2") {   }
    
        public bool IsCheckMove()
        {
            bool blnRet = false;
            #region Проверка на дурака, что координаты не выходят за пределы доски
            if ((rowFrom < 0)
                || (rowFrom > 7)
                || (rowTo < 0)
                || (rowTo > 7))
            {
                Console.WriteLine("Заданы не верные цифровые обозначения строк доски.");
                return blnRet;
            }
            #endregion
            return true;
        }

        public string  From { get; set; }
        public string  To { get; set; }
        public int colFrom { get; set; }
        public int rowFrom { get; set; }
        public int colTo { get; set; }
        public int rowTo { get; set; }
        
    }
    
    public enum Horizontal { A,B,C,D,E,F,G,H };
}
