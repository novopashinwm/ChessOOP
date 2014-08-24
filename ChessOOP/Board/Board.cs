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

        //Выводи находящиеся на доске фигуры
        public void PrintBoard()
        { 

        }

        //Начальная расстановка фигур
        public void PlaceFigures()
        { 
           //Ставим пешки
            for (int i = 0; i < 8; i++)
            {
                //Большие буквы для белых , маленькие для черных
                Pawn objPawn = new Pawn(FigureColor.White, "P", i,1);                
                _board[i, 1] = (Figure)  objPawn;
                objPawn = new Pawn(FigureColor.Black, "p", i,6);
                _board[i, 6] = (Figure)objPawn;               
            }

            //Расставляем ладьи
            Rock objRock = new Rock (FigureColor.White , "R", 0,0);
            SetFigure(objRock, "r", 0, 7);

            //Расставляем коней            
            Knight  objKnight = new Knight (FigureColor.White,"N",0,1);
            SetFigure(objKnight, "n", 1, 6);

           //Раставляем  слонов
            Bishop objBishop = new Bishop(FigureColor.White, "b", 0, 2);
            SetFigure(objBishop, "b", 2, 5);

            //Расставляем ферзей
            Queen objQueen = new Queen(FigureColor.White, "q", 0, 3);
            SetFigureOne(objQueen, "q", 3);

            //Расставляем королей
            King objKing = new King(FigureColor.White, "k", 0, 4);
            SetFigureOne(objKing, "k", 4);

        }

        public void SetFigure(Figure objFigure, string symbol, int left, int rigth)
        {
            SetFigureOne(objFigure, symbol, left);
            SetFigureOne(objFigure, symbol, rigth);
        }

        public void SetFigureOne(Figure objFigure, string symbol, int intCol)
        {
            objFigure = new Figure(FigureColor.White, symbol.ToUpper(), 0, intCol);
            _board[0, intCol] = objFigure;

            objFigure = new Figure(FigureColor.Black, symbol.ToLower(), 7, intCol );
            _board[7, intCol] = objFigure;
            
        }


        //Выбрать фигуру
        public Move  SelectFigureConsole()
        {
            throw new NotImplementedException();
        }
    }
}
