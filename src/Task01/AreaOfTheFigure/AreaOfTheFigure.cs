namespace AreaOfTheFigure;

public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract bool Rectangular();
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }

    public override bool Rectangular()
    {
        return false;
    }
}

public class Triangle : Shape
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public override double CalculateArea()
    {
        double s = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }

    public override bool Rectangular()
    {
        double a = _sideA * _sideA;
        double b = _sideB * _sideB;
        double c = _sideC * _sideC;

        return Math.Abs(a + b - c) < 0.001 || Math.Abs(a + c - b) < 0.001 || Math.Abs(b + c - a) < 0.001;
    }
}
