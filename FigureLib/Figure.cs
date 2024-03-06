
namespace FigureLib
{
    public abstract class Figure
    {
        protected double? area;

        public double Area
        {
            get
            {
                if (!area.HasValue)
                {
                    getArea();
                }
                return area.Value;
            }
        }

        protected abstract void getArea();
    }
}
