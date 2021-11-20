namespace DesignPatterns.Solid.LiskovSubstitution;

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle() { }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString() => $"Width: {Width}\nHeight: {Height}\nArea: {Width * Height}";
}
