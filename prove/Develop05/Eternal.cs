public class Eternal : Goal
{

   public Eternal(string type, string name, string desc, string points, string bonus, string iter, string done) : base(type, name, desc, points, bonus, iter, done)
    {
        Console.Clear();
        base.ShowPoints();
    }

    public override void ListGoals(Goal i)
    {
        Console.WriteLine($"[{i._complete}] {i._name} ({i._desc})");
    }
}