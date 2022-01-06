using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns.Structural.Proxy;

public class WebParser : IWebParser
{
    private readonly int _pagesCount;
    private readonly int _sectionsCount;
    private readonly List<byte[]> _images;

    public int GetPagesCount() => _pagesCount;
    public int GetSectionsCount() => _sectionsCount;
    public List<byte[]> GetImages() => _images;

    public WebParser(string url)
    {
        Thread.Sleep(10000);
        // Get website content logic using url
        _pagesCount = 55;
        _sectionsCount = 135;
        _images = new List<byte[]> { new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 } };
    }
}
