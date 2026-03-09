using System;

// README.md를 읽고 코드를 작성하세요.
Shape[] shapes = new Shape[]
{
    new Circle {Radius = 5},
    new Circle {Radius = 15},
    new Rectangle {Width = 4, Height = 6},
    new Rectangle {Width = 5, Height = 5},
    new Square {Side = 7}
};

foreach (Shape shape in shapes)
{
    Console.WriteLine(ClassifyShape(shape));
}

string ClassifyShape(Shape shape) => shape switch
{
    //Circle c => $"원(반지름: {c.Radius}): {1} , 넓이: {c.CalculateArea():F2}",
    Circle c => c switch
    {
        { Radius: >= 10 } => $"원(반지름: {c.Radius}): 큰 원, 넓이: {c.CalculateArea():F2}",
        _ => $"원(반지름: {c.Radius}): 작은 원, 넓이: {c.CalculateArea():F2}"
    },
    Rectangle r => r switch
    {
        { Width: var width, Height: var height} when width == height => $"직사각형({width}x{height}): 정사각형 모양의 직사각형, 넓이: {r.CalculateArea():F2}",
        _ => $"직사각형({r.Width}x{r.Height}): 일반 직사각형, 넓이: {r.CalculateArea():F2}"
    },
    Square s => $"정사각형({s.Side}): 정사각형, 넓이: {s.CalculateArea():F2}"
};