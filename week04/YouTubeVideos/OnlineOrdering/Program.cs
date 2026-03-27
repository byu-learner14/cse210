using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA customer
        Address address1 = new Address("123 Maple Street", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-456", 29.99m, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC-789", 12.50m, 3));
        order1.AddProduct(new Product("Laptop Stand", "LS-101", 45.00m, 1));

        // Order 2 - International customer
        Address address2 = new Address("456 Ocean Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emma Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Bluetooth Headphones", "BH-202", 89.99m, 1));
        order2.AddProduct(new Product("Phone Charger", "PC-303", 15.75m, 4));

        // Display results (exactly as the assignment requires)
        DisplayOrder(order1, "Order 1");
        DisplayOrder(order2, "Order 2");
    }

    private static void DisplayOrder(Order order, string orderTitle)
    {
        Console.WriteLine("=========================================");
        Console.WriteLine(orderTitle);
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
        Console.WriteLine("=========================================\n");
    }
}