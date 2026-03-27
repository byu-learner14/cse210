using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }   // length in seconds

    // Private list so only the Video class manages its comments
    private List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // This is the required method from the spec
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Helper so Program.cs can display the comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}