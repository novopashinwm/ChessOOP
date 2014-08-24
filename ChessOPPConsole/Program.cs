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

        }
    }
}
