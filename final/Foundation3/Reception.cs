public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, string address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public void Full()
    {
        Console.WriteLine($"FULL DETAILS\nEvent Type: Reception\nEvent Title: {_title}\nDescription: {_desc}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nRSVP To: {_email}\n");
    }
}