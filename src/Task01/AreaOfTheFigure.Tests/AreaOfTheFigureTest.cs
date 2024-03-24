namespace AreaOfTheFigure.Tests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_ReturnsCorrectValue()
    {
        var circle = new Circle(5);
        Assert.Equal(Math.PI * 25, circle.CalculateArea(), 3);
    }

    [Fact]
    public void Rectangular_ReturnsFalse()
    {
        var circle = new Circle(5);
        Assert.False(circle.Rectangular());
    }
}

public class TriangleTests
{
    [Fact]
    public void CalculateArea_ReturnsCorrectValue()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.CalculateArea(), 3);
    }

    [Fact]
    public void Rectangular_ReturnsCorrectValue()
    {
        var rightTriangle = new Triangle(3, 4, 5);
        Assert.True(rightTriangle.Rectangular());

        var nonRightTriangle = new Triangle(3, 3, 3);
        Assert.False(nonRightTriangle.Rectangular());
    }
}
