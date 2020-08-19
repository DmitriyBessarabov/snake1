using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;
       

        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            pList = new List<Point>();
            for (int x = xLeft; xLeft <= xRight; xRight++ )
            {
                Point p = new Point(x, y, symb);
                pList.Add ( p );
            }

        }
        public void Drow()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }


    }
}
