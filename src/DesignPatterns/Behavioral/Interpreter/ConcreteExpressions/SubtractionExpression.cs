namespace DesignPatterns.Behavioral.Interpreter.ConcreteExpressions;

public class SubtractionExpression : IExpression
{
    private readonly IExpression _minuend;
    private readonly IExpression _subtrahend;

    public SubtractionExpression(IExpression minuend, IExpression subtrahend)
    {
        _minuend = minuend;
        _subtrahend = subtrahend;
    }


    public int Interpret(Context context)
    {
        return _minuend.Interpret(context) - _subtrahend.Interpret(context);
    }
}
