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
        private Figure objFrom;
        private Figure objTo;

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
                Pawn objPawn = new Pawn(FigureColor.White, 'P', 1, i);                
                _board[1, i] = (Figure)  objPawn;
                //маленькие для черных
                objPawn = new Pawn(FigureColor.Black, 'p', 6,i);
                _board[6, i] = (Figure)objPawn;               
            }

            //Расставляем ладьи
            Rock objRock = new Rock (FigureColor.White , 'R', 0,0);
            SetFigure(objRock, 'r', 0, 7);

            //Расставляем коней            
            Knight  objKnight = new Knight (FigureColor.White,'N',0,1);
            SetFigure(objKnight, 'n', 1, 6);

           //Раставляем  слонов
            Bishop objBishop = new Bishop(FigureColor.White, 'b', 0, 2);
            SetFigure(objBishop, 'b', 2, 5);

            //Расставляем ферзей
            Queen objQueen = new Queen(FigureColor.White, 'q', 0, 4);
            SetFigureOne(objQueen, 'q', 4);

            //Расставляем королей
            King objKing = new King(FigureColor.White, 'k', 0, 3);
            SetFigureOne(objKing, 'k', 3);

        }

        public FigureColor WhichMove
        {          
            get;
            set;
        }

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
            Console.ReadLine();
            Console.Clear();
        }

        //Начальная установка парных фигур
        public void SetFigure(Figure objFigure, char symbol, int left, int rigth)
        {
            SetFigureOne(objFigure, symbol, left);
            SetFigureOne(objFigure, symbol, rigth);
        }

        //Начальная установка одной фигуры для белых и черных
        public void SetFigureOne(Figure objFigure, char symbol, int intCol)
        {
            objFigure = new Figure(FigureColor.White, char.Parse(symbol.ToString ().ToUpper ()), 0, intCol);
            _board[0, intCol] = objFigure;

            objFigure = new Figure(FigureColor.Black, char.Parse (symbol.ToString().ToLower()), 7, intCol);
            _board[7, intCol] = objFigure;
            
        }

        //Парсинг хода
        bool IsMoveValid(string strMove)
        {
            bool blnRet = false;

            try
            {
                string [] arrMove = strMove.Split(' ');
                //Если не правильная буква, то формируется Exception
                objMove.colFrom = (int)Enum.Parse(typeof(Horizontal), arrMove[0].Substring(0, 1).ToUpper());
                objMove.rowFrom = int.Parse(arrMove[0].Substring(1, 1)) - 1;
                objMove.colTo = (int)Enum.Parse(typeof(Horizontal), arrMove[0].Substring(0, 1).ToUpper());
                objMove.rowTo = int.Parse(arrMove[1].Substring(1, 1)) - 1;

                #region Проверка на дурака, что координаты не выходят за пределы доски
                if ((objMove.rowFrom < 0) 
                    || (objMove.rowFrom > 7) 
                    || (objMove.rowTo < 0) 
                    || (objMove.rowTo > 7))
                {
                    Console.WriteLine("Заданы не верные цифровые обозначения строк доски.");
                    return blnRet;
                }
                #endregion

                objFrom  = _board[objMove.rowFrom, objMove.colFrom];
                objTo = _board[objMove.rowTo, objMove.colTo];
                
                if (objFrom == null )
                {
                    Console.WriteLine ("Начальные координаты "+ arrMove[0] + " не содержат фигуру");
                    return blnRet ;
                }


                #region Проверяем, что сейчас ход той фигуры, цвет которой указан
                if (WhichMove == FigureColor.White)                
                {
                    if (Char.IsLower (objFrom.Symbol) )                    
                    {
                        Console.WriteLine("Сейчас ход белых!");
                        return blnRet;
                    }
                }
                else
                {
                    if  (Char.IsLetter ( objFrom.Symbol ) )
                    {
                        Console.WriteLine("Сейчас ход черных!");
                        return blnRet;
                    }

                }
                #endregion
                #region Проверяем, что клетка куда пойдет фигура не содержит фигуру того же цвета

                if (Char.IsLower(objFrom.Symbol) == Char.IsLower (objTo.Symbol))
                {
                    Console.WriteLine("Фигура пошла на клетку с фигурой того же цвета!");
                    return blnRet;
                }
                #endregion

                switch (objFrom.GetType().ToString () )
                {
                    //Пешки                    
                    case "Pawn":
                        //if (!PawnCheck()) return blnRet;
                        blnRet = true;
                        break;
                    //Слоны
                    case "Bishop":
                        //if (!BishopCheck()) return blnRet;
                        blnRet = true;
                        break;
                    case "":
                        break;
                }
                
            }
            catch
            { }
            return blnRet;
        }

        //Выбрать фигуру
        //Фактически вводи ход в формате e2 e4
        public string   SelectFigureConsole()
        {
            Console.WriteLine("");
            return Console.ReadLine();
            
        }
    }
}
