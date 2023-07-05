public class Video
{
    public string _title;
    public string _author;
    public int _length;
    List<Video> _videos = new List<Video>();
    List<Comment> _comments = new List<Comment>();

    public Video() {}

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddVideo(Video newObject)
    {
        _videos.Add(newObject);
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public void ListVideos()
    {
        Console.WriteLine(" ");
        foreach (Video i in _videos) // loop through the '_videos' list
        {
            Console.WriteLine($"Video Title: {i._title}, Producer: {i._author}, Length: {i._length} seconds, Comments: {GetCount(i._title)}.");
            foreach (Comment c in _comments)
            {
                if(i._title == c._title)
                {
                    Console.WriteLine($"     Commenter - {c._name} says: {c._comment}");
                }
            } Console.WriteLine(" ");
        } 
    }

    public int GetCount(string title)
    {
        int totalComments = 0;
        foreach (Comment i in _comments)
        {
            if (i._title == title)
            {
                totalComments ++;
            }
        }
        return totalComments;
    }
}