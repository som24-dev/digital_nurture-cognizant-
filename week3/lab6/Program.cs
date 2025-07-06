using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // ✅ Insert initial data only if not present
        if (!context.Categories.Any())
        {
            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };

            await context.Categories.AddRangeAsync(electronics, groceries);

            var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
            var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

            await context.Products.AddRangeAsync(product1, product2);
            await context.SaveChangesAsync();

            Console.WriteLine(" Initial data seeded.\n");
        }

        //  Update Product Price
        var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
        if (product != null)
        {
            product.Price = 70000;
            await context.SaveChangesAsync();
            Console.WriteLine($" Updated {product.Name}'s price to ₹{product.Price}");
        }

        //  Delete Discontinued Product
        var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
        if (toDelete != null)
        {
            context.Products.Remove(toDelete);
            await context.SaveChangesAsync();
            Console.WriteLine($" Deleted discontinued product: {toDelete.Name}");
        }

        //  Show final product list
        Console.WriteLine("\n Final Product List:");
        var products = await context.Products.Include(p => p.Category).ToListAsync();
        foreach (var p in products)
        {
            Console.WriteLine($"- {p.Name} | ₹{p.Price} | {p.Category.Name}");
        }
    }
}
