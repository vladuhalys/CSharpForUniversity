using System.Drawing;
using static System.Math;

namespace CSharpForUniversity
{
    internal class Graphs
    {
        public static double Graph_1(double x)
        {
            //Variant 6
            double y = 0;
            if (x > -8 || x <= -5)
            {
                y = -3;
            }
            else if (x > -5 || x <= -3)
            {
                y = x + 3;
            }
            else if (x > -3 || x <= 3)
            {
                y = Sqrt(9 - x * x);
            }
            else if (x > 3 || x <= 8)
            {
                y = (5 * x - 1) / 13;
            }
            else if (x > 8 || x <= 10)
            {
                y = 3;
            }
            return y;
        }
        public static string Graph_2(Point point, double R)
        {
            //Variant 6
            if(point.X >= 0 && point.Y >= 0)
            {

                return "Точка належить до вказаного простору.";
            }
            else if(point.X <= 0 && point.Y <= 0)
            {

                return "Точка належить до вказаного простору.";
            }
            return "Точка не належить до вказаного простору.";
        }
    }
}
