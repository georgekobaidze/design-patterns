using System;

namespace DesignPatterns.Behavioral.Interpreter.ConcreteExpressions;

public class DivisionExpression : IExpression
{
    private readonly IExpression _dividend;
    private readonly IExpression _divisor;

    public DivisionExpression(IExpression dividend, IExpression divisor)
    {
        _dividend = dividend;
        _divisor = divisor;
    }
    
    public int Interpret(Context context)
    {
        var divisor = _divisor.Interpret(context);
        if (divisor == 0)
            throw new NullReferenceException("The divisor can't be 0");

        return _dividend.Interpret(context) / _divisor.Interpret(context);
    }
}
