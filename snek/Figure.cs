using System;
using System.Collections.Generic;
using System.Text;

namespace snek
{
    class Figure
    {
        protected List<point> pList;
        public void Draw()
        {
            foreach (point p in pList)
            {
                p.Draw();
            }
        }
    }
}
