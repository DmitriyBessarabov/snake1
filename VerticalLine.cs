using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> plist;

        public VerticalLine(int yTop, int yBottom, int x, char symb)
        {
            plist = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, symb);
                plist.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}