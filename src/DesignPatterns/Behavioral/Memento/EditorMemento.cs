namespace DesignPatterns.Behavioral.Memento;

public class EditorMemento
{
    public string Text { get; set; }

    public EditorMemento(string text)
    {
        Text = text;
    }
}
