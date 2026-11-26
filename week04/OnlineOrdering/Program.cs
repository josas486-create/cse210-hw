using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // First customer
            Address address1 = new Address(
                "123 Main Street",
                "New York",
                "New York",
                "USA");

            Customer customer1 = new Customer("John Smith", address1);

            // First order
            Order order1 = new Order(customer1);

            Product product1 = new Product("Laptop", "P101", 800, 1);
            Product product2 = new Product("Mouse", "P102", 25, 2);

            order1.AddProduct(product1);
            order1.AddProduct(product2);


            // Second customer
            Address address2 = new Address(
                "15 Oxford Street",
                "London",
                "England",
                "United Kingdom");

            Customer customer2 = new Customer("David Brown", address2);

            // Second order
            Order order2 = new Order(customer2);

            Product product3 = new Product("Keyboard", "P103", 45, 1);
            Product product4 = new Product("Headphones", "P104", 60, 2);
            Product product5 = new Product("USB Cable", "P105", 10, 3);

            order2.AddProduct(product3);
            order2.AddProduct(product4);
            order2.AddProduct(product5);


            // Display first order
            Console.WriteLine("FIRST ORDER");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());

            Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

            Console.WriteLine("\n");


            // Display second order
            Console.WriteLine("SECOND ORDER");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());

            Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        }
    }
}