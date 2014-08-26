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
            objBoard.PrintBoard();
            objBoard.WhichMove = FigureColor.White;
            string strMove = objBoard.SelectFigureConsole();
            if (!objBoard.IsMoveValid(strMove))
            { 
            }
            /*
            HelpFirst();
            Console.ReadLine();
            SetFigures(white);
            SetFigures(black);
            string strMove = " ";
                        
            //Здесь находится сердце программы
            while (strMove != "")
            {
                PrintBoard();
                PrintMove();
                strMove = Console.ReadLine();
                if ( !IsMoveValid (strMove) && strMove !="")
                {
                    Console.WriteLine("Не правильный ход!");
                    continue ;
                }
                ReplaceFigure();
                //Передача хода противнику
                isWhite = !isWhite;
                
            }
            Console.WriteLine("Игра закончена!");
            Console.ReadLine();             
             */
        }
    }
}
