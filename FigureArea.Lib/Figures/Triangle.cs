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

    // Конструктор треугольника
    public Triangle(double sideA, double sideB, double sideC)
    {
        // Проверяем чтобы все стороны были больше 0
        if (sideA > 0 && sideB > 0 && sideC > 0)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            // Периметр - сумма трёх сторон
            _perimeter = _sideA + _sideB + _sideC;
            // Гипотенуза - найбольшая сторона
            _hypotenuse = Math.Max(_sideA, Math.Max(_sideB, _sideC));
            // Катет первый - найменьшая сторона
            _legOne = Math.Min(_sideA, Math.Min(_sideB, _sideC));
            // Катет второй - периметр минус сумма гипотенузы и первого катета
            _legTwo = _perimeter - (_hypotenuse + _legOne);
        }
        else
        {
            throw new Exception("Invalid sides");
        }

        // И эксепшен, если гипотенуза больше суммы катетов
        if (_hypotenuse > _legOne + _legTwo)
        {
            throw new Exception
            (
                "The hypotenuse must not be greater than the sum of the legs"
            );
        }
    }
    
    // Возвращаем площадь фигуры (треугольника)
    public double GetFigureArea()
    {
        // Площадь треуголиника равна квадратному корню из произведения
        // полупериметра на три разности полуперитра минус каждая сторона
        var triangleArea = Math.Sqrt
        (
            (_perimeter / 2)
            * (_perimeter / 2 - _sideA)
            * (_perimeter / 2 - _sideB)
            * (_perimeter / 2 - _sideC)
        );

        return triangleArea;
    }

    // Булевый метод определяет прямоугольный ли треугольник
    // ...статический метод сделал, чтоб не править интерфейс
    public static bool RightTriangleTest()
    {
        // Если гипотенуза в квадрате минус сумма квадратов катетов
        // равна 0, то треугольник прямоугольный
        var rightTriangle = Math.Abs
        (
            Math.Pow(_hypotenuse, 2) 
            - (Math.Pow(_legOne, 2) 
            + Math.Pow(_legTwo, 2))
        ) == 0;

        return rightTriangle;
    }
}