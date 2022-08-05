namespace AreaFigureDLL
{
    public class AreaTriangle : Area
    {
        private double PerimeterFloor { get; set; } // полупериметр
        private double Area { get; set; } // площадь
        private List<double> ListSide { get; } // список значений сторон треугольника

        public bool IsRect => IsRectangular(); // проверка на прямоугольность

        public AreaTriangle(double firstSide, double secondSide, double thirdSide)
        {
            ListSide = new List<double> { firstSide, secondSide, thirdSide };
            foreach (var i in ListSide)
            {
                if (i < 0)
                    throw new ArgumentOutOfRangeException("неверное значение");
            }
            PerimeterFloor = (firstSide + secondSide + thirdSide) / 2;
            Area = PerimeterFloor;
        }

        public override double AreaFig()
        {
            foreach (var side in ListSide)
            {
                Area *= PerimeterFloor - side;
            }
            return Math.Sqrt(Area);
        }
        private bool IsRectangular()
        {
            ListSide.Sort();

            return ListSide[2] == Math.Sqrt(Math.Pow(ListSide[0], 2) + Math.Pow(ListSide[1], 2));
        }
    }
}
