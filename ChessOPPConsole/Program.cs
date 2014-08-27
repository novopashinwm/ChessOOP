using System;
using System.Collections.Generic;
using System.Text;
using ChessOOP;

namespace ChessOPPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Создаем объект доска и выводим сообщение для консоли
            Board objBoard = new Board();
            objBoard.HelpFirst();
            objBoard.PlaceFigures();
            
            objBoard.WhichMove = FigureColor.White;

            string strMove = " ";
            while (strMove != "")
            {
                objBoard.PrintBoard();
                objBoard.PrintMove();
                strMove = objBoard.SelectFigureConsole();
                if (!objBoard.IsMoveValid(strMove) && strMove !="")
                {
                    Console.WriteLine("Не правильный ход!");
                    continue;
                }
                objBoard.ReplaceFigure ();
                objBoard.NextMove(); 
            }
            Console.WriteLine("Игра закончена!");
            Console.ReadLine();
            
        }
    }
}
