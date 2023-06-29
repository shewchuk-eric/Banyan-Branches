public class Simple : Goal
{
    
    public Simple(string type, string name, string desc, string points, string bonus, string iter, string done) : base(/*type, name, desc, points, bonus, iter, done*/)
    {
        _type = type;
        _name = name; // name of goal
        _desc = desc; // description of goal
        _points = points; // how many points the goal is worth
        _bonus = bonus; // how many bonus points the goal will earn
        _iter = iter; // how many times the goal NEEDS to be completed
        _done = done; // how many time the goal HAS been completed
        _complete = " ";
        Console.Clear();
        base.ShowPoints();
    }

    public override void ListGoals(Goal i)
    {
        Console.WriteLine($"[{_complete}] {_name} ({_desc})");
    }
}