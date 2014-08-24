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

            string strStroka = "   " + new string('-', 32);
            Console.WriteLine(strStroka);
            for (int i = _board.GetLength(0) - 1; i >= 0; i--)
            {
                Console.Write("{0} !", i + 1);
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    string strFigure = "";
                    if (_board[i, j] == null)
                        strFigure = " ";
                    else
                        strFigure = ((Figure)_board[i, j]).Symbol;
                    
                    Console.Write(" {0} !", strFigure ) ;
                }

                Console.WriteLine();
                Console.WriteLine(strStroka);
            }

            Console.Write("   ");
            for (int i = 0; i < 8; i++)
                Console.Write(" {0}  ", (Horizontal ) i);

            Console.WriteLine();
        }

        //Начальная расстановка фигур
        public void PlaceFigures()
        { 
           //Ставим пешки
            for (int i = 0; i < 8; i++)
            {
                //Большие буквы для белых , маленькие для черных
                Pawn objPawn = new Pawn(FigureColor.White, "P", 1, i);                
                _board[1, i] = (Figure)  objPawn;
                objPawn = new Pawn(FigureColor.Black, "p", 6,i);
                _board[6, i] = (Figure)objPawn;               
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

        /// <summary>
        /// Первичная помощь по программе
        /// </summary>
        public  void HelpFirst()
        {
            Console.WriteLine();
            Console.WriteLine("Упрощенная шахматная программа");
            Console.WriteLine("1) 1- пешки белых, 2- пешки черных, 3- слон белых, 4 - слон черных;");
            Console.WriteLine("2) пешки ходят на 1 и 2 шага вперед");
            Console.WriteLine("3) пешки умеют бить");
            Console.WriteLine("4) слоны ходят и бьют.");
            Console.WriteLine(" ");
            Console.WriteLine("Для того чтобы сделать ход, нужно ввести через пробел начальные");
            Console.WriteLine("и конечные координаты фигуры");
            Console.WriteLine("Например:a2  a3");
            Console.WriteLine("Для выхода не вводя никаких координат просто нажмите ввод.");
            Console.WriteLine("Нажмите любую клавишу.....");
            Console.WriteLine();
            Console.ReadLine();
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
