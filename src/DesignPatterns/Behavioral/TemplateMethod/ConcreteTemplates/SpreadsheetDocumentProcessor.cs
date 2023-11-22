using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.TemplateMethod.ConcreteTemplates;

public class SpreadsheetDocumentProcessor : DocumentProcessor
{
    private List<List<string>> _spreadsheetData = new(); // Dummy field, pretending to be storing spreadsheet data

    protected override void LoadData()
    {
        Console.WriteLine("Loading spreadsheet data from a file.");
        // Loading logic for spreadsheet data
    }

    protected override void ParseData()
    {
        Console.WriteLine("Parsing spreadsheet data.");
        // Specific parsing logic for spreadsheet documents
    }

    protected override void AnalyzeData()
    {
        Console.WriteLine("Analyzing spreadsheet data.");
        // Specific analysis logic for spreadsheet documents
    }

    protected override void RenderDocument()
    {
        Console.WriteLine("Rendering spreadsheet document.");
        // Rendering logic for spreadsheet documents
    }

    protected override void SaveResult()
    {
        Console.WriteLine("Saving the processed spreadsheet document.");
        // Saving logic for spreadsheet documents
    }
}
