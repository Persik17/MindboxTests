
namespace FigureLib.Figures
{
    public class Triangle : Figure
    {
        private double a = 0, b = 0, c = 0;

        public double A
        {
            get { return a; }
            set
            {
                a = value;
                getArea();
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                b = value;
                getArea();
            }
        }

        public double C
        {
            get { return c; }
            set
            {
                c = value;
                getArea();
            }
        }

        public Triangle() { }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool IsCorrect()
        {
            return isCorrect(A, B, C);
        }

        public bool IsRightAngledTriangle(double side1, double side2, double side3)
        {
            double[] sides = new double[] { side1, side2, side3 };
            Array.Sort(sides);
            return (sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1]);
        }

        public bool IsRight()
        {
            return IsRightAngledTriangle(A, B, C);
        }

        private static bool isCorrect(double x, double y, double z)
        {
            return y + z - x > 0
                && x + z - y > 0
                && x + y - z > 0;
        }

        public static double GetAreaBySides(double x, double y, double z)
        {
            if (x <= 0 || y <= 0 || z <= 0 || !isCorrect(x, y, z))
            {
                return 0;
            }
            else
            {
                double p = (x + y + z) / 2;
                return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            }
        }

        protected override void getArea()
        {
            area = GetAreaBySides(A, B, C);
        }
    }
}
