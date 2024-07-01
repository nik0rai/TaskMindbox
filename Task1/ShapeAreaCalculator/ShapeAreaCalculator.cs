namespace ShapeAreaCalculator
{
    public class ShapeAreaCalculator
    {
        private readonly Dictionary<string, IShapeAreaStrategy> strategies = new();

        public ShapeAreaCalculator()
        {
            strategies["circle"] = new CircleAreaStrategy();
            strategies["triangle"] = new TriangleAreaStrategy();
        }

        public double Calculate(string shapeType, params double[] args)
        {
            if (!strategies.TryGetValue(shapeType, out var strategy))
            {
                throw new ArgumentException($"Unknown shape type: {shapeType}");
            }

            return strategy.Calculate(args);
        }

        public string GetTypeOfShape(string shapeType, params double[] args)
        {
            if (!strategies.TryGetValue(shapeType, out var strategy))
            {
                throw new ArgumentException($"Unknown shape type: {shapeType}");
            }

            return strategy.GetTypeOfShape(args);
        }
    }
}
