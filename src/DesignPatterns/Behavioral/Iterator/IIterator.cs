namespace DesignPatterns.Behavioral.Iterator;

public interface IIterator
{
    bool HasNext();
    Post Next();
}
