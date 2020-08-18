using System;

using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point();
            p1.x = 1;
            p1.y = 3;
            p1.symb = '*';
            p1.Draw();

            point p2 = new point();
            p2.x = 4;
            p2.y = 5;
            p2.symb = '#';
            p2.Draw();


            Console.ReadLine();
        }
    }
}