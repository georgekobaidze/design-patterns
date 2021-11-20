namespace DesignPatterns.Solid.LiskovSubstitution;

public class Square : Rectangle //Geometrically, all squares are rectangles, so it should be a good idea right?
{
    //That will work, but again: BAD PRACTICE ALERT!
    public new int Width { set { base.Width = base.Height = value; } }
    public new int Height { set { base.Width = base.Height = value; } }
}
