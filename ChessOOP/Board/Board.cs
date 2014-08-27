using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    //Класс доска
    public class Board
    {
        private Figure  [,] _board  = new Figure [8,8];
        private Move objMove;

        public Figure From { get; set; }
        public Figure To { get; set; }

        public Figure[,] BRD { get { return _board; } }
        
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
                        strFigure = ((Figure)_board[i, j]).Symbol.ToString ();
                    
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
                //Большие буквы для белых                 
                _board[1, i] = new Pawn(FigureColor.White, 'P');
                //маленькие для черных                
                _board[6, i] = new Pawn(FigureColor.Black, 'p');
            }

            //Расставляем ладьи            
            SetFigure("Rock", 'r', 0, 7);

            //Расставляем коней                        
            SetFigure("Knight", 'n', 1, 6);

           //Раставляем  слонов            
            SetFigure("Bishop", 'b', 2, 5);

            //Расставляем ферзей            
            SetFigureOne("Queen", 'q', 4);

            //Расставляем королей            
            SetFigureOne("King", 'k', 3);

        }

        //Фигуры какого цвета в данный момент ходят
        public FigureColor WhichMove  { get; set; }

        /// <summary>
        /// Первичная помощь по программе
        /// </summary>
        public  void HelpFirst()
        {
            Console.WriteLine();
            Console.WriteLine("Шахматная программа");
            Console.WriteLine("1) БОЛЬШИМИ БУКВАМИ - белые фигуры, маленькими - черные ;");
            Console.WriteLine("2) p-пешка, r- ладья, n-конь, b - слон, q- ферзь, k- король."); 
            Console.WriteLine(" ");
            Console.WriteLine("Для того чтобы сделать ход, нужно ввести через пробел начальные");
            Console.WriteLine("и конечные координаты фигуры");
            Console.WriteLine("Например:a2  a3");
            Console.WriteLine("Для выхода не вводя никаких координат просто нажмите ввод.");
            Console.WriteLine("Нажмите любую клавишу.....");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }

        //Начальная установка парных фигур
        public void SetFigure(string strFigureType , char symbol, int left, int rigth)
        {
            SetFigureOne(strFigureType, symbol, left);
            SetFigureOne(strFigureType, symbol, rigth);
        }

        //Начальная установка одной фигуры для белых и черных
        public void SetFigureOne(string strFigureType, char symbol, int intCol)
        {
            char chrUp = char.Parse(symbol.ToString().ToUpper());
            char chrLower = char.Parse(symbol.ToString().ToLower());
            
            switch (strFigureType)
            { 
                case "Bishop":
                    _board[0, intCol] = new Bishop (FigureColor.White, chrUp);
                    _board[7, intCol] = new Bishop (FigureColor.Black, chrLower);
                    break;
                case "King":
                    _board[0, intCol] = new King(FigureColor.White, chrUp);
                    _board[7, intCol] = new King (FigureColor.Black, chrLower);
                    break;
                case "Knight":
                    _board[0, intCol] = new Knight(FigureColor.White, chrUp);
                    _board[7, intCol] = new Knight (FigureColor.Black, chrLower);
                    break;
                case "Queen":
                    _board[0, intCol] = new Queen(FigureColor.White, chrUp);
                    _board[7, intCol] = new Queen (FigureColor.Black, chrLower);
                    break;
                case "Rock":
                    _board[0, intCol] = new Rock (FigureColor.White, chrUp);
                    _board[7, intCol] = new Rock (FigureColor.Black, chrLower);
                    break;
            }
                        
        }


        public  void PrintMove()
        {
            Console.WriteLine();
            Console.WriteLine("Ход {0}.", (WhichMove == FigureColor.White) ? "белых" : "черных");            
            Console.WriteLine();
        }
        public void ReplaceFigure()
        {
            _board[objMove.rowFrom, objMove.colFrom] = null ;
            _board[objMove.rowTo, objMove.colTo] = From;
        }

        public void NextMove()
        {
            int i = (int)WhichMove;
            i++;
            //Пока 2 цвета фигур - черные и белые - соответственно значения в enum-ах 0,1
            if (i > 1) i = 0;
            
            WhichMove = (FigureColor)i;            
        }

        //Парсинг хода
        public bool IsMoveValid(string strMove)
        {
            bool blnRet = false;

            try
            {
                objMove = new Move(strMove);
                if (!objMove.IsCheckMove()) return blnRet;
                From = _board[objMove.rowFrom, objMove.colFrom];
                To = _board[objMove.rowTo, objMove.colTo];

                if (From == null)
                {
                    Console.WriteLine("Начальные координаты " + objMove.From + " не содержат фигуру");
                    return blnRet;
                }
               
                //Вызываем проверку хода фигурой - необходима реализация в каждой фигуре отдельно
                if (!From.IsCheckMove(objMove, this)) return blnRet  ;                
                
            }
            catch
            { }
            blnRet = true;
            return blnRet;
        }

        //Выбрать фигуру
        //Фактически вводи ход в формате e2 e4
        public string   SelectFigureConsole()
        {
            Console.WriteLine("Введите ход");
            return Console.ReadLine();
            
        }
    }
}
