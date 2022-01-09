using System;
using Newtonsoft.Json;

namespace DesignPatterns.Structural.Flyweight;

// Stores a common portion (intrinsic) of the whole state
// The rest of the state (extrinsic) is accepted via its method parameters
public class Flyweight
{
    private Soldier _sharedState;

    public Flyweight(Soldier soldier) => _sharedState = soldier;

    public void Operation(Soldier uniqueState)
    {
        var sharedStateAsJson = JsonConvert.SerializeObject(_sharedState);
        var uniqueStateAsJson = JsonConvert.SerializeObject(uniqueState);

        Console.WriteLine($"Shared state: {sharedStateAsJson}\nUnique state: {uniqueStateAsJson}");
    }
}
