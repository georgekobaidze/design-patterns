using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator;

public class SocialMediaFeed : IPostCollection
{
    private readonly List<Post> _posts = new();
    
    public void AddPost(Post post)
    {
        _posts.Add(post);
    }

    public IIterator CreateIterator()
    {
        return new PostIterator(this);
    }

    public int Count
    {
        get { return _posts.Count; }
    }

    public Post this[int index]
    {
        get { return _posts[index]; }
    }
}
