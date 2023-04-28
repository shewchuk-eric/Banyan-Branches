public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>(); // create a list that jobs can be added into

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job i in _jobs) // loop through the '_jobs' list
        {
            i.Display(); // call the Job 'Display' method to print each job as the loop iterates
        }
    }
}