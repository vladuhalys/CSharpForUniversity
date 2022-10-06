using static System.Math;

namespace CSharpForUniversity
{
    internal class LinearEquations
    {
        public static double Equation_1(double A)
        {
            //z1 = cosA + cos2A + cos6A + cos7A
            double z1 = Cos(A) + Cos(2*A) + Cos(6*A) + Cos(7 * A);
            return z1;
        }
        public static double Equation_2(double A)
        {
            //z2 = 4 cos A/2 * cos 5/2 * cos4A
            double z2 = 4 * Cos(A / 2) * Cos(5 / 2) * Cos(4 * A);
            return z2;
        }
    }
}
