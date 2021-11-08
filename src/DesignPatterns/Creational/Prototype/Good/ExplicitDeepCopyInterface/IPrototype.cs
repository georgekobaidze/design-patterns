namespace DesignPatterns.Creational.Prototype.Good.ExplicitDeepCopyInterface
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
