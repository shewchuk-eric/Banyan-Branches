public class Event
{
    protected string _title;
    protected string _desc;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _desc = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void Short(string type)
    {
        Console.WriteLine($"SHORT DESCRIPTION\nEvent Type: {type}\nEvent Title: {_title}\nDate: {_date}\n");
    }

    public void Standard()
    {
        Console.WriteLine($"STANDARD DETAILS\nEvent Title: {_title}\nDescription: {_desc}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\n");
    }
}