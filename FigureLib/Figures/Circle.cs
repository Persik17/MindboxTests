
namespace FigureLib.Figures
{
    public class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                getArea();
            }
        }
        public Circle() { }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        protected override void getArea()
        {
            area = GetArea(Radius);
        }

        public static double GetArea(double r)
        {
            if (r > 0)
                return Math.PI * Math.Pow(r, 2);
            else return 0;
        }
    }
}
