public class Order
{
    
    private string _name; // customer name
    private string _item1;
    private string _item2;
    private string _item3;
    private string _order;
    
    List<Order> _orders = new List<Order>();
    
    public Order(string name, string pro1, string pro2, string pro3)
    {
        _name = name;
        _item1 = pro1;
        _item2 = pro2;
        _item3 = pro3;
    }

    public void AddOrder(Order newOrder)
    {
        _orders.Add(newOrder);
    }

    public int GetTotal()
    {
        int total = 0;
        return total;
    }

    public string GetOrder(Order order)
    {
        Console.WriteLine($"ORDER:"); // print packing list header
        foreach (Order i in _orders) // loop through array to place into current entries for display
        {
            if (order._name == i._name)
            {
                _order = ($"{i._item1},{i._item2},{i._item3}");
            }
        }
        return _order;
    }

    public string GetShipping()
    {
        string shipLabel = "";
        return shipLabel;
    }
}
        