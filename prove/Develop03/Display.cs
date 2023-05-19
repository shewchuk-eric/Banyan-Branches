public class Display
{
    public void OutputOne(string citation, string verse)
    {
        Console.Clear();
        Console.WriteLine($"{citation} - {verse}");
    }

    public void OutputTwo(string scripture)
    {
        Console.Clear();
        Console.WriteLine($"{scripture}");
    }
}