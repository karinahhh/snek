using System;
using System.Collections.Generic;
using System.Text;

namespace snek
{
    class VerticalLine
    {
        public VerticalLine(int yLeft, int yReight, int x, char sym)
        {
            pList = new List<point>();
            for (int y = yLeft; y <= yReight; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }
        }

    }
}
