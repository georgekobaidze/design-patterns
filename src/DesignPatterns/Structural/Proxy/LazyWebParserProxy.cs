using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy;

public class LazyWebParserProxy : IWebParser
{
    private WebParser _webParser;
    private readonly string _website;

    public LazyWebParserProxy(string website) => _website = website;

    public List<byte[]> GetImages()
    {
        CheckInit();
        return _webParser.GetImages();
    }

    public int GetPagesCount()
    {
        CheckInit();
        return _webParser.GetPagesCount();
    }

    public int GetSectionsCount()
    {
        CheckInit();
        return _webParser.GetSectionsCount();
    }

    // Checks if _webParser is initialized. If not, initializes it
    private void CheckInit()
    {
        if (_webParser == null)
            _webParser = new WebParser(_website);
    }
}
