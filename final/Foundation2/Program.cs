using System;


class Program {
    static void Main(string[] args) {
        Address address1 = new Address("123 Main St", "New York", "NY", "10001", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Product[] products1 = {
            new Product("   Jump Rope Set", 121, 10.0, 2),
            new Product("   Blue-Race Car", 254, 15.89, 2),
            new Product("   Train Set", 133, 20.50, 1)
        };
        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("10-123 1/2 Main St. NW", "Montreal", "QC","H32 2YZ", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Product[] products2 = {
            new Product("   My First BabyDoll", 4, 25.99, 1),
            new Product("   My First BabyDoll-Wardrobe", 5, 20.99, 1),
            new Product("   Cradle", 6, 35.50, 1),
            new Product("   My First BabyDoll-Feeding Kit", 7, 19.99, 1)
        };
        Order order2 = new Order(customer2, products2);

        Console.WriteLine("\nOrder 1:");
        Console.WriteLine($"Total Price: {order1.TotalPrice:C}\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel);
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel);

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine($"Total Price: {order2.TotalPrice:C}\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel);
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel);
    }
}