using System;

namespace DesignPatterns.Behavioral.Iterator;

public class PostIterator : IIterator
{
    private SocialMediaFeed socialMediaFeed;
    private int index = 0;

    public PostIterator(SocialMediaFeed socialMediaFeed)
    {
        this.socialMediaFeed = socialMediaFeed;
    }

    public bool HasNext()
    {
        return index < socialMediaFeed.Count;
    }

    public Post Next()
    {
        if (HasNext())
        {
            return socialMediaFeed[index++];
        }

        throw new InvalidOperationException("End of the feed.");
    }
}
