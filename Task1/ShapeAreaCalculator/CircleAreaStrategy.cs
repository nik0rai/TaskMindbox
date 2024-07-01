namespace ShapeAreaCalculator
{
    public class CircleAreaStrategy : ICircleAreaStrategy
    {
        public double Calculate(double radius)
        {
            #region Validation

            if (radius < 0)
            {
                throw new ArgumentException("Radius can't be negative");
            }

            #endregion

            return Math.PI * radius * radius;
        }

        public double Calculate(params double[] args) => Calculate(args[0]);

        public string GetTypeOfShape() => "circle";

        public string GetTypeOfShape(params double[] args) => GetTypeOfShape();
    }

    public class TriangleAreaStrategy : ITriangleAreaStrategy
    {
        public double Calculate(double a, double b, double c)
        {
            #region Validation

            if ((a < 0) || (b < 0) || (c < 0))
            {
                throw new ArgumentException("Side or sides can't be negative");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Such triangle doesn't exist!");
            }

            #endregion

            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Calculate(params double[] args) => Calculate(args[0], args[1], args[2]);

        public string GetTypeOfShape(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
            {
                if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b)) return "right";
                else if ((a * a > b * b + c * c) || (b * b > a * a + c * c) || (c * c > a * a + b * b)) return "obtuse";
                else return "acute";
            }
            else throw new ArgumentException("Such triangle doesn't exist!");
        }

        public string GetTypeOfShape(params double[] args) => GetTypeOfShape(args[0], args[1], args[2]);

    }
}