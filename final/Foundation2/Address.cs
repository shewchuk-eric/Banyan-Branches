public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    private string _country;
    

    public Address() // make methods accessible to other classes
    {    }

    public Address(string street, string city, string state, string zip, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }

    public string GetAddressLabel(Address current)
    {
        string label = ($"{this._street}\n{this._city}, {this._state} {this._zip}");
        return label;
    }

    public bool Locale(Address address)
    {
        if (this._country == "USA")
        { 
            return true;}
        else 
        {
            return false;}
    }
}