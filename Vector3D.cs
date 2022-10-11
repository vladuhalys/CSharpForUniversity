

namespace CSharpForUniversity
{
    public class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D()
        {
            X = Y = Z = 0;
        }
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Vector3D operator +(Vector3D vL, Vector3D vR)
        {
            return new Vector3D(vL.X + vR.X, vL.Y + vR.Y, vL.Z + vR.Z);
        }
        public static Vector3D operator -(Vector3D vL, Vector3D vR)
        {
            return new Vector3D(vL.X - vR.X, vL.Y - vR.Y, vL.Z - vR.Z);
        }
        public static double operator *(Vector3D vL, Vector3D vR)
        {
            return (vL.X * vR.X)+(vL.Y * vR.Y)+(vL.Z * vR.Z);
        }
        
        public double Length()
        {
            return Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
        }
        public static double operator ^(Vector3D vL, Vector3D vR)
        {
            return Math.Acos((vL * vR) / (vL.Length() * vR.Length()));
        }
        public override string ToString()
        {
            return $"({X}; {Z}; {Y})";
        }
    }
}
