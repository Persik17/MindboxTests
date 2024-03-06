
namespace FigureLib.Figures
{
    public class Polygone : Figure
    {
        public List<Dot> Dots;

        public Polygone() { }

        public Polygone(List<Dot> dots)
        {
            this.Dots = dots;
            getArea();
        }

        private double getAreaByDots(Dot first, Dot second)
        {
            return (first.Y + second.Y) * (second.X - first.X) / 2;
        }

        public void UpdateArea()
        {
            getArea();
        }

        protected override void getArea()
        {
            if (Dots.Count <= 2)
            {
                area = 0;
            }
            else
            {
                double currentarea = 0;

                for (int i = 1; i < Dots.Count; ++i)
                {
                    currentarea += getAreaByDots(Dots[i - 1], Dots[i]);
                }

                currentarea += getAreaByDots(Dots[Dots.Count - 1], Dots[0]);
                area = Math.Abs(currentarea);
            }
        }
    }
}
