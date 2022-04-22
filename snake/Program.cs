using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
        

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 25, '+');
            VerticalLine leftVerticalLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightVerticalLine = new VerticalLine(78, 0, 24, '+');

            upLine.Drow();
            downLine.Drow();
            leftVerticalLine.Drow();
            rightVerticalLine.Drow();

            Point p1 = new Point(4, 7, '#');
            p1.Draw();

            Console.ReadLine();
        }
    }
}