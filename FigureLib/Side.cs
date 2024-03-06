
namespace FigureLib
{
    public class Side
    {
        private double? length;
        private Dot dotA, dotB;

        public double Length
        {
            get
            {
                if (!length.HasValue)
                {
                    getLengthFromAToB();
                }
                return length.Value;
            }
        }

        public Dot DotA
        {
            get { return dotA; }
            set
            {
                dotA = (Dot)value.Clone();
                getLengthFromAToB();
            }
        }

        public Dot DotB
        {
            get { return dotB; }
            set
            {
                dotB = (Dot)value.Clone();
                getLengthFromAToB();
            }
        }

        public Side(Dot A, Dot B)
        {
            this.DotA = (Dot)A.Clone();
            this.DotB = (Dot)B.Clone();
        }

        private void getLengthFromAToB()
        {
            length = Side.GetLength(DotA, DotB);
        }

        public static double GetLength(Dot A, Dot B)
        {
            if (A == null || B == null)
            {
                return 0;
            }
            else
            {
                return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            }
        }
    }
}
