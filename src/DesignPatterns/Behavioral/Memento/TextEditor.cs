using System;

namespace DesignPatterns.Behavioral.Memento;

public class TextEditor // Originator
{
    private string _text;

    public string Text
    {
        get => _text;
        set
        {
            Console.WriteLine($"Updating text: {value}");
            _text = value;
        }
    }
    
    public EditorMemento Save()
    {
        Console.WriteLine("Saving current state.");
        return new EditorMemento(_text);
    }

    public void Restore(EditorMemento memento)
    {
        _text = memento.Text;
        Console.WriteLine($"Restoring to previous state: {_text}");
    }
}
