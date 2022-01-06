using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy;

public interface IWebParser
{
    int GetPagesCount();
    int GetSectionsCount();
    List<byte[]> GetImages();
}
