using FigureArea.Lib.Interfaces;

namespace FigureArea.Lib.Figures;

public class Circle : IFigure
{
    private const double Pi = Math.PI;
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius > 0)
        {
            _radius = radius;
        }
        else
        {
            throw new Exception("Invalid radius");
        }
    }
    
    public double GetFigureArea()
    {
        var circleArea = Pi * Math.Pow(_radius, 3);
        
        return Math.Round(circleArea, 3);
    }
}