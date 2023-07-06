using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment);
    }

    public void DisplayVideo()
    {
        string lengthStr = _length.ToString();
        Console.WriteLine("");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {lengthStr} seconds");
        Console.WriteLine("Comments: ");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
        }
        Console.WriteLine("");
    }
}