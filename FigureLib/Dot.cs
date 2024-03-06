namespace FigureLib
{
    public class Dot : ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Dot(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }

        public object Clone()
        {
            return new Dot(X, Y);
        }
    }
}
