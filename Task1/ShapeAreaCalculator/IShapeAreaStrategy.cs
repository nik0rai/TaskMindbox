namespace ShapeAreaCalculator
{
    public interface IShapeAreaStrategy
    {
        double Calculate(params double[] args);
        string GetTypeOfShape(params double[] args);
    }

    public interface ICircleAreaStrategy : IShapeAreaStrategy
    {
        double Calculate(double radius);
        string GetTypeOfShape();
    }

    public interface ITriangleAreaStrategy : IShapeAreaStrategy
    {
        double Calculate(double a, double b, double c);
        string GetTypeOfShape(double a, double b, double c);
    }
}