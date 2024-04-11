namespace Geometry
{
    internal interface IFigure
    {
        double CalculateArea();
    }

    public class Circle : IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус должен быть больше 0");
            }
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : IFigure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                throw new ArgumentException("Стороны должны быть больше 0");
            }
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public double CalculateArea()
        {
            double semiPerimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
        }
        public bool IsRightTriangle()
        {
            double[] sides = { Side1, Side2, Side3 };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
