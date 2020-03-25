using System;namespace snek{    class Program    {        static void Main(string[] args)        {
            static void Main(string[] args)
            {
                Console.Title = "Snake";
                Console.SetWindowSize(101, 26);

                HorisontalLine upline = new HorisontalLine(0, 100, 0, '+');
                HorisontalLine downline = new HorisontalLine(0, 100, 25, '+');
                VerticalLine leftline = new VerticalLine(1, 25, 0, '+');
                VerticalLine rightline = new VerticalLine(1, 25, 100, '+');
                upline.Draw();
                downline.Draw();
                leftline.Draw();
                rightline.Draw();

                point p = new point(4, 5, '*');

                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Draw();
                snake.Move();
                Thread.Sleep(100);
                snake.Move();
                Thread.Sleep(100);
                snake.Move();
                Thread.Sleep(100);
                //Console.ReadLine();
            }

        }    }}