﻿using System;
using System.Collections.Generic;
using System.Text;

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



        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}


//wgwegewgwegwegwh
//oiipip