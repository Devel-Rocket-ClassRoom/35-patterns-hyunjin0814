class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }

}