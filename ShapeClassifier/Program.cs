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
    Circle c => "",
    Rectangle r => "",
    Square s => ""
};