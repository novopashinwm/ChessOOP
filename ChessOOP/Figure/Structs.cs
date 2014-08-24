using System;
using System.Collections.Generic;
using System.Text;

namespace ChessOOP
{
    public  enum FigureColor { Black, White};

    public struct Move
    {
        public int colFrom;
        public int rowFrom;
        public int colTo;
        public int rowTo;
    }
    
    public enum Horizontal { A,B,C,D,E,F,G,H };
}
