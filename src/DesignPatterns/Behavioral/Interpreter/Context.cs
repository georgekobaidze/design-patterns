using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Interpreter;

public class Context
{
    public IDictionary<string, int> Variables = new Dictionary<string, int>();
}
