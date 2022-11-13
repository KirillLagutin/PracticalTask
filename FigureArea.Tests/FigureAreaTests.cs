using FigureArea.Lib.Figures;
using FigureArea.Lib.Interfaces;

namespace FigureArea.Tests;

[TestClass]
public class FigureAreaTests
{
    [TestMethod]
    // Проверка на отрицательный радиус
    public void CircleNegativeRadiusTest()
    {
        Assert.ThrowsException<Exception>(() => new Circle(-3));
    }
    
    [TestMethod]
    // Проверка на отрицательные стороны, несколько вариантов
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
    // Проверка на вычисление площади круга
    public void GetCircleAreaTest()
    {
        IFigure circle = new Circle(3);
        // Получаемые данные
        var circleAreaActual = circle.GetFigureArea();
        // Ожидаемые данные
        const double circleAreaExpected = 28.274;
        
        // Сравнение данных
        Assert.AreEqual(circleAreaExpected, circleAreaActual);
    }
    
    [TestMethod]
    // Проверка на вычисление площади треугольника
    public void GetTriangleAreaTest()
    {
        IFigure triangle = new Triangle(3, 4, 5);
        // Получаемые данные
        var triangleAreaActual = triangle.GetFigureArea();
        // Ожидаемые данные
        const double triangleAreaExpected = 6;
        
        // Сравнение данных
        Assert.AreEqual(triangleAreaExpected, triangleAreaActual);
    }
    
    [TestMethod]
    // Проверка на то, является ли треугольник прямоугольным
    public void RightTriangleTest()
    {
        IFigure triangle = new Triangle(3, 4, 5);
        // Получаемые данные
        var rightTriangleActual = Triangle.RightTriangleTest();
        // Ожидаемые данные
        const bool rightTriangleExpected = true;
        
        // Сравнение данных
        Assert.AreEqual(rightTriangleExpected, rightTriangleActual);
    }
}