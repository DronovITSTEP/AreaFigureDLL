namespace AreaFigureDLL
{
    public class AreaCircle : Area
    {
        private double Radius { get; }

        public AreaCircle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("неверное значение");
            Radius = radius;

        }
        public override double AreaFig()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

