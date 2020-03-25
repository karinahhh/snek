using System;
using System.Collections.Generic;
using System.Text;

namespace snek
{
    class point
    {
        public int x;
        public int y;
        public char sym;
        public bool isPoison;
        public point()
        {

        }
        public point(int x_, int y_, char sym_)
        {
            x = x_;
            y = y_;
            sym = sym_;
            //this.isPoison = isPoison;
        }
        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else
            {
                y = y + offset;
            }

        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
