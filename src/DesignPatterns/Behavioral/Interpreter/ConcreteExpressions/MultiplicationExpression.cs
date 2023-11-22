namespace DesignPatterns.Behavioral.Interpreter.ConcreteExpressions;

public class MultiplicationExpression : IExpression
{
    private readonly IExpression _multiplier;
    private readonly IExpression _multiplicand;

    public MultiplicationExpression(IExpression multiplier, IExpression multiplicand)
    {
        _multiplier = multiplier;
        _multiplicand = multiplicand;
    }
    
    public int Interpret(Context context)
    {
        return _multiplier.Interpret(context) * _multiplicand.Interpret(context);
    }
}
