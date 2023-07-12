public class Outdoor : Event
{
    private string _forecast;

    public Outdoor(string title, string description, string date, string time, string address, string forecast) : base(title, description, date, time, address)
    {
        _forecast = forecast;
    }

    public void Full()
    {
        Console.WriteLine($"Event Type: Outdoor\nEvent Title: {_title}\nDescription: {_desc}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nWeather Forecast: {_forecast}\n");
    }
}