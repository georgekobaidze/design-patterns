using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Memento;

public class CommandHistory
{
    private Stack<EditorMemento> history = new Stack<EditorMemento>();

    public void Push(EditorMemento memento)
    {
        history.Push(memento);
    }

    public EditorMemento Pop()
    {
        return history.Pop();
    }
}
