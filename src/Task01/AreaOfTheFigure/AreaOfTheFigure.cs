namespace AreaOfTheFigure;

public abstract class Shape
{
    public abstract double Area();
    public abstract bool Rectangular();
}

public class Circle : Shape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override bool Rectangular()
    {
        return false;
    }
}

public class Triangle : Shape
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double Area()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override bool Rectangular()
    {
        double A = SideA * SideA;
        double B = SideB * SideB;
        double C = SideC * SideC;

        return Math.Abs(A + B - C) < 0.001 || Math.Abs(A + C - B) < 0.001 || Math.Abs(B + C - A) < 0.001;
    }
}