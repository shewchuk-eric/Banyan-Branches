public class Checklist : Goal
{

    public Checklist(string type, string name, string desc, string points, string bonus, string iter, string done) : base(type, name, desc, points, bonus, iter, done)
    {
        Console.Clear();
        base.ShowPoints();
    }

    public override void ListGoals(Goal i)
    {
        Console.WriteLine($"[{_complete}] {_name} ({_desc}) -- Currently completed: {_done}/{_iter}");
    }
}