using FigureArea.Lib.Figures;
using FigureArea.Lib.Interfaces;

/*
    Напишите на C# библиотеку для поставки внешним клиентам, 
  которая умеет вычислять площадь круга по радиусу и треугольника 
  по трем сторонам. Дополнительно к работоспособности оценим:

 * Юнит-тесты

 * Легкость добавления других фигур

 * Вычисление площади фигуры без знания типа фигуры в compile-time

 * Проверку на то, является ли треугольник прямоугольным 
*/


// Пример работы библиотеки в консоли
IFigure circle = new Circle(3);
IFigure triangle = new Triangle(3, 4, 5);

var circleArea = circle.GetFigureArea();
var triangleArea = triangle.GetFigureArea();
var rightTriangle = Triangle.RightTriangleTest();

Console.WriteLine($"Circle area = {circleArea}");

Console.WriteLine($"Triangle area = {triangleArea}");
Console.WriteLine($"Is this triangle right angled? = {rightTriangle}");


/*
    В базе данных MS SQL Server есть продукты и категории. 
  Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
*/
 
/*
   Файл с SQL запросом находится в этом проекте отдельным файлом
 */
 