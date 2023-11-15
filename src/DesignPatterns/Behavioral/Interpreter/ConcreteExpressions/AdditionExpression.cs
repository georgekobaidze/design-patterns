namespace DesignPatterns.Behavioral.Interpreter.ConcreteExpressions;

public class AdditionExpression : IExpression
{
    private readonly IExpression _firstAddend;
    private readonly IExpression _secondAddend;

    public AdditionExpression(IExpression firstAddend, IExpression secondAddend)
    {
        _firstAddend = firstAddend;
        _secondAddend = secondAddend;
    }
    
    public int Interpret(Context context)
    {
        return _firstAddend.Interpret(context) + _secondAddend.Interpret(context);
    }
}
