using FigureArea.Lib.Figures;
using FigureArea.Lib.Interfaces;

namespace FigureArea.Tests;

[TestClass]
public class FigureAreaTests
{
    [TestMethod]
    public void CircleNegativeRadiusTest()
    {
        Assert.ThrowsException<Exception>(() => new Circle(-3));
    }
    
    [TestMethod]
    public void TriangleNegativeSidesTest()
    {
        Assert.ThrowsException<Exception>(() => new Triangle(-3, 4, 5));
        Assert.ThrowsException<Exception>(() => new Triangle(-3, -4, 5));
        Assert.ThrowsException<Exception>(() => new Triangle(-3, 4, -5));
        Assert.ThrowsException<Exception>(() => new Triangle(3, -4, 5));
        Assert.ThrowsException<Exception>(() => new Triangle(3, -4, -5));
        Assert.ThrowsException<Exception>(() => new Triangle(3, 4, -5));
        Assert.ThrowsException<Exception>(() => new Triangle(-3, -4, -5));
        Assert.ThrowsException<Exception>(() => new Triangle(0, 4, 5));
        Assert.ThrowsException<Exception>(() => new Triangle(0, -4, 5));
        Assert.ThrowsException<Exception>(() => new Triangle(0, -4, -5));
        Assert.ThrowsException<Exception>(() => new Triangle(0, 0, 0));
    }
    
    [TestMethod]
    public void GetCircleAreaTest()
    {
        IFigure circle = new Circle(3);
        var circleAreaActual = circle.GetFigureArea();
        const double circleAreaExpected = 84.823;
        
        Assert.AreEqual(circleAreaExpected, circleAreaActual);
    }
    
    [TestMethod]
    public void GetTriangleAreaTest()
    {
        IFigure triangle = new Triangle(3, 4, 5);
        var triangleAreaActual = triangle.GetFigureArea();
        const double triangleAreaExpected = 6;
        
        Assert.AreEqual(triangleAreaExpected, triangleAreaActual);
    }
    
    [TestMethod]
    public void RightTriangleTest()
    {
        IFigure triangle = new Triangle(3, 4, 5);
        var rightTriangleActual = Triangle.RightTriangleTest();
        const bool rightTriangleExpected = true;
        Assert.AreEqual(rightTriangleExpected, rightTriangleActual);
    }
}