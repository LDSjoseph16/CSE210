using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Mabini St", "Iligan City", "Lanao del Norte", "Philippines");
        Customer customer1 = new Customer("Juan Dela Cruz", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Barong Tagalog", "BT-001", 2500.00, 1));
        order1.AddProduct(new Product("Dried Mangoes", "DM-50", 150.00, 5));

        Address address2 = new Address("789 Broadway", "New York", "NY", "USA");
        Customer customer2 = new Customer("Maria Clara", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Abaca Handbag", "AB-99", 1200.00, 1));
        order2.AddProduct(new Product("Banana Chips", "BC-12", 80.00, 10));
        order2.AddProduct(new Product("Sungka Board", "SB-05", 500.00, 1));

        Console.WriteLine("========================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order1.CalculateTotal():0.00}");
        Console.WriteLine("========================================\n");

        Console.WriteLine("========================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order2.CalculateTotal():0.00}");
        Console.WriteLine("========================================");
    }
}