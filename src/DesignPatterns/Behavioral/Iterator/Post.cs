namespace DesignPatterns.Behavioral.Iterator;

public class Post
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Post(string title, string content)
    {
        Title = title;
        Content = content;
    }
}
