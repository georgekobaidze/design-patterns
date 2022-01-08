using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Composite;

// This is a helper interface that will be implemented by a composite.
// Methods defined in this interface can be also defined in a component as abstract methods.
// But instead we define them here because we shouldn't make leaf class implement those methods.
public interface IGiftOperations
{
    void AddGift(Gift gift);
    void RemoveGift(Gift gift);
}
