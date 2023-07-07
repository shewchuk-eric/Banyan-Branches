public class Product
{
    private string _proName;
    private string _proID;
    private int _price;
    private int _quantity;
    List<Product> _products = new List<Product>();

    public Product() {} // allow method access to other classes
    public Product(string name, string ID, int price, int quantity)
    {
        _proName = name;
        _proID = ID;
        _price = price;
        _quantity = quantity;
    }

    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }

    public void PrintProducts(string items, bool location)
    {
        int orderTotal = 0;
        int shippingCost = 35;
        string[] parts = items.Split(","); // split the string into component parts
        foreach (string p in parts){
            foreach (Product i in _products)
            {
                if (p == i._proName)
                {
                    Console.WriteLine($"Item: {i._proName}, Item ID: {i._proID}, Quantity Ordered: {i._quantity}");
                    orderTotal += i._price;
                }
            }
        }
        Console.WriteLine($"\nSUB TOTAL: ${orderTotal}.00");
        if (location)
        {
            shippingCost = 5;
        }
        Console.WriteLine($"SHIPPING: ${shippingCost}.00");
        Console.WriteLine($"ORDER TOTAL: ${orderTotal + shippingCost}.00\n");
    }
}