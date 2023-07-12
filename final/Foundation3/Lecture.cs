public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, string date, string time, string address, string speaker, string capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void Full()
    {
        Console.WriteLine($"Event Type: Lecture\nEvent Title: {_title}\nDescription: {_desc}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nSpeaker: {_speaker}\nCapacity: {_capacity}\n");
    }
    
}