using System;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            context.Database.EnsureCreated();

            // CREATE
            var product = new Product { Name = "Laptop", Price = 1200.00M };
            context.Products.Add(product);
            context.SaveChanges();

            // READ
            Console.WriteLine("\nAll Products:");
            foreach (var p in context.Products)
            {
                Console.WriteLine($"ID: {p.ProductId}, Name: {p.Name}, Price: {p.Price}");
            }

            // UPDATE
            var firstProduct = context.Products.First();
            firstProduct.Price = 999.99M;
            context.SaveChanges();
            Console.WriteLine("\nProduct updated.");

            // DELETE
            context.Products.Remove(firstProduct);
            context.SaveChanges();
            Console.WriteLine("Product deleted.");
        }
    }
}
