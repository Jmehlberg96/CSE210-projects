using System;


class Program {
    static void Main(string[] args) 
    {
        Console.Clear();
        Console.WriteLine("Foundation 2: Products\n");
        
        //Order 1 
        Address address1 = new Address("123 Main St", "New York", "NY", "10001", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Product[] products1 = 
        {
            new Product("   Jump Rope Set", 121, 10.0, 2),
            new Product("   Blue-Race Car", 254, 15.89, 2),
            new Product("   Train Set", 133, 20.50, 1)
        };
        Order order1 = new Order(customer1, products1);

        //Order 2
        Address address2 = new Address("10-123 1/2 Main St. NW", "Montreal", "QC","H32 2YZ", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Product[] products2 = 
        {
            new Product("My First BabyDoll", 4, 25.99, 1),
            new Product("My First BabyDoll-Wardrobe", 5, 20.99, 1),
            new Product("Cradle", 6, 35.50, 1),
            new Product("My First BabyDoll-Feeding Kit", 7, 19.99, 1)
        };
        Order order2 = new Order(customer2, products2);

        //Order 3
        Address address3 = new Address("412 E Grand St.", "Gallatin", "MO", "64640", "USA");
        Customer customer3 = new Customer("Kaia Scott", address3);
        Product[] products3 = 
        {
            new Product("Bouncy Ball", 120, 5.99, 3),
            new Product("Chess Set", 301, 19.99, 1),
            new Product("Kite", 16, 15.99, 2),
        };
        Order order3 = new Order(customer3, products3);

        Console.WriteLine("\nOrder 1:");
        Console.WriteLine($"Total Price: {order1.CalculateTotalPrice()}\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine($"Total Price: {order2.CalculateTotalPrice()}\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());

        Console.WriteLine("\nOrder 3:");
        Console.WriteLine($"Total Price: {order3.CalculateTotalPrice()}\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.ShippingLabel());
    }
}