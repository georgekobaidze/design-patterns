namespace DesignPatterns.Behavioral.TemplateMethod;

public abstract class DocumentProcessor
{
    // Template Method
    public void ProcessDocument()
    {
        LoadData();
        ParseData();
        AnalyzeData();
        RenderDocument();
        SaveResult();
    }

    protected abstract void LoadData();
    protected abstract void ParseData();
    protected abstract void AnalyzeData();
    protected abstract void RenderDocument();
    protected abstract void SaveResult();
}
