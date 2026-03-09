class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Side * Side;
    }

    public override string ClassifyShape()
    {
        return $"정사각형({Side}): 정사각형, 넓이: {CalculateArea():F2}";
    }
}
