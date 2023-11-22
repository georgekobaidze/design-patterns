using System;

namespace DesignPatterns.Behavioral.TemplateMethod.ConcreteTemplates;

public class TextDocumentProcessor : DocumentProcessor
{
    private string _text;
    protected override void LoadData()
    {
        Console.WriteLine("Loading text data from a file.");
        _text = "This is the content of the text document.";
    }

    protected override void ParseData()
    {
        Console.WriteLine("Parsing text data.");
        // Specific parsing logic for text documents
    }

    protected override void AnalyzeData()
    {
        Console.WriteLine("Analyzing text data.");
        // Specific analysis logic for text documents
    }

    protected override void RenderDocument()
    {
        Console.WriteLine("Rendering text document.");
        Console.WriteLine($"Text Content: {_text}");
    }

    protected override void SaveResult()
    {
        Console.WriteLine("Saving the processed text document.");
        // Specific saving logic for text documents
    }
}
