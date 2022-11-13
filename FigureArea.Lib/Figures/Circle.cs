using FigureArea.Lib.Interfaces;

namespace FigureArea.Lib.Figures;

public class Circle : IFigure
{
    private const double Pi = Math.PI;
    private readonly double _radius;

    // Конструктор круга
    public Circle(double radius)
    {
        // Проверяем чтобы радиус был больше 0
        if (radius > 0)
        {
            _radius = radius;
        }
        else
        {
            throw new Exception("Invalid radius");
        }
    }
    
    // Возвращаем площадь фигуры (круга)
    public double GetFigureArea()
    {
        // Площадь круга равна произведения ПИ на радиус в квадрате
        var circleArea = Pi * Math.Pow(_radius, 2);
        
        // Округлил до трёх символов после запятой
        return Math.Round(circleArea, 3);
    }
}