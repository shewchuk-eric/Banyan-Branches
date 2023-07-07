using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Customers
        Address add1 = new Address("1428 Elm Street","Springwood","OH","46556","USA");
        Customer cu1 = new Customer("Wes Craven", add1);
        Address add2 = new Address("90 Orchard Street","New York","NY","10002","USA");
        Customer cu2 = new Customer("Barry Sonnenfeld", add2);

        // Create Products
        Product pu = new Product();
        Product pro1 = new Product("Chainsaw","Echo 400cc",399,1);
        pu.AddProduct(pro1);
        Product pro2 = new Product("Hockey Mask","NHL 85",49,1);
        pu.AddProduct(pro2);
        Product pro3 = new Product("Cinematic Blood 1qt","CB1",19,31);
        pu.AddProduct(pro3);
        Product pro4 = new Product("Tiny Cricket","TCB 14",1499,2);
        pu.AddProduct(pro4);
        Product pro5 = new Product("RayBan Wayfarer","RB-W01",189,6);
        pu.AddProduct(pro5);
        Product pro6 = new Product("Orions Belt","OBG-XS",279,1);
        pu.AddProduct(pro6);

        // Create Orders
        Order ord1 = new Order(cu1.GetName(cu1), "Chainsaw", "Hockey Mask", "Cinematic Blood 1qt");
        ord1.AddOrder(ord1);
        Order ord2 = new Order(cu2.GetName(cu2), "Tiny Cricket", "RayBan Wayfarer", "Orions Belt");
        ord2.AddOrder(ord2);


        // Get Packing Label For Order One
        string packingList1 = ord1.GetOrder(ord1);
        bool shipping = add1.Locale(add1);
        pu.PrintProducts(packingList1, shipping);

        // Get Shipping Label For Order One
        string name1 = cu1.GetName(cu1);
        string address1 = add1.GetAddressLabel(add1);
        Console.WriteLine($"\nSHIP TO:\n{name1}\n{address1}\n");


        // Get Packing Label For Order Two
        string packingList2 = ord2.GetOrder(ord2);
        bool shipping2 = add2.Locale(add2);
        pu.PrintProducts(packingList2, shipping2);

        // Get Shipping Label For Order Two
        string name2 = cu2.GetName(cu2);
        string address2 = add2.GetAddressLabel(add2);
        Console.WriteLine($"\nSHIP TO:\n{name2}\n{address2}\n");

    }
}