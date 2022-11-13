using FigureArea.Lib.Interfaces;

namespace FigureArea.Lib.Figures;

public class Triangle : IFigure
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;
    
    private readonly double _perimeter;
    private static double _hypotenuse;
    private static double _legOne;
    private static double _legTwo;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA > 0 && sideB > 0 && sideC > 0)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            _perimeter = _sideA + _sideB + _sideC;
            _hypotenuse = Math.Max(_sideA, Math.Max(_sideB, _sideC));
            _legOne = Math.Min(_sideA, Math.Min(_sideB, _sideC));
            _legTwo = _perimeter - (_hypotenuse + _legOne);
        }
        else
        {
            throw new Exception("Invalid sides");
        }

        if (_hypotenuse > _perimeter - _hypotenuse)
        {
            throw new Exception
            (
                "The hypotenuse must not be greater than the sum of the legs"
            );
        }
    }
    
    public double GetFigureArea()
    {
        var triangleArea = Math.Sqrt
        (
            (_perimeter / 2)
            * (_perimeter / 2 - _sideA)
            * (_perimeter / 2 - _sideB)
            * (_perimeter / 2 - _sideC)
        );

        return triangleArea;
    }

    public static bool RightTriangleTest()
    {
        var rightTriangle = Math.Abs
        (
            Math.Pow(_hypotenuse, 2) 
            - (Math.Pow(_legOne, 2) 
            + Math.Pow(_legTwo, 2))
        ) == 0;

        return rightTriangle;
    }
}