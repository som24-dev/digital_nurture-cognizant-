using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        if (!context.Categories.Any())
        {
            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };

            await context.Categories.AddRangeAsync(electronics, groceries);

            var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
            var product2 = new Product { Name = "Smartphone", Price = 40000, Category = electronics };
            var product3 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

            await context.Products.AddRangeAsync(product1, product2, product3);
            await context.SaveChangesAsync();

            Console.WriteLine(" Seed data inserted.\n");
        }

        var filtered = await context.Products
            .Where(p => p.Price > 1000)
            .OrderByDescending(p => p.Price)
            .ToListAsync();

        Console.WriteLine(" Filtered & Sorted Products (Price > ₹1000):");
        foreach (var p in filtered)
        {
            Console.WriteLine($"- {p.Name} | ₹{p.Price}");
        }

        var productDTOs = await context.Products
            .Select(p => new { p.Name, p.Price })
            .ToListAsync();

        Console.WriteLine("\n Projected Product DTOs:");
        foreach (var dto in productDTOs)
        {
            Console.WriteLine($"- {dto.Name} → ₹{dto.Price}");
        }
    }
}
