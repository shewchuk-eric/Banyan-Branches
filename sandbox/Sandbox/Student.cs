public class Student : Person
{
    private string _number;

    // calling the parent constructor using "base"!
    public Student(string name, string number) : base(name)
    {
      _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }

    public void TestPrint()
    {
        string number = base.GetName();
        Console.WriteLine($"Student Number: {number}");
    }
}