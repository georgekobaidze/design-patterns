using System;

namespace DesignPatterns.Behavioral.Interpreter;

public class VariableExpression : IExpression
{
    private string _variableName;

    public VariableExpression(string variableName)
    {
        this._variableName = variableName;
    }

    public int Interpret(Context context)
    {
        if (context.Variables.TryGetValue(_variableName, out var interpret))
        {
            return interpret;
        }
        
        throw new InvalidOperationException($"Variable {_variableName} not found.");
    }
}
