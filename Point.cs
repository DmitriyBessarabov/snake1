﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Snake
{
    class point
    {
        public int x;
        public int y;
        public char symb;

        public point()
        {

        }
        public point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
