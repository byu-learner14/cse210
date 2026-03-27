public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor makes it easy to create comments
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}