public class Reference
{
    private string _citation;
    
    public Reference(string name, string chapter, string verse)
    {
        _citation = ($"{name} {chapter}:{verse}");
    }

    public Reference(string name, string chapter, string start, string end)
    {
        _citation = ($"{name} {chapter}:{start}-{end}");
    }

    public Reference(string name, string chapter, string start, string comma, string end)
    {
        _citation = ($"{name} {chapter}:{start}{comma} {end}");
    }

    public string GetCitation()
    {
        return _citation;
    }
}