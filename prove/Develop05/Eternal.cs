public class Eternal : Goal
{
    // private string _name; // name of goal
    // private string _desc; // description of goal
    // private string _points; // how many points the goal is worth
    // private string _type = "Simple";
    // private string _bonus = "void";
    // private string _iter = "void";
    // private string _done = "void";
    // private string _score = "void";
    // private string _complete = " ";

   public Eternal(string line)
    {
        string[] parts = line.Split(",");
        _type = parts[0];
        _name = parts[1];
        _desc = parts[2];
        _points = parts[3];
        _bonus = parts[4];
        _iter = parts[5];
        _done = parts[6];
        _complete = parts[7];
    }
   
   public Eternal(string type, string name, string desc, string points, string bonus, string iter, string done) : base(type, name, desc, points, bonus, iter, done)
    {
        Console.Clear();
        base.ShowPoints();
    }

    public override void ListGoals()
    {
        //Console.WriteLine($"[{i._complete}] {i._name} ({i._desc})");
    }
}