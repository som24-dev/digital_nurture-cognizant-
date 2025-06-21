using System;

// Step 2: Define Product class
public class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    // Step 3.1: Linear Search
    public static Product LinearSearch(Product[] products, string targetName)
    {
        foreach (Product product in products)
        {
            if (product.ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
            {
                return product;
            }
        }
        return null;
    }

    // Step 3.2: Binary Search (by ProductName, must be sorted)
    public static Product BinarySearch(Product[] products, string targetName)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int comparison = string.Compare(products[mid].ProductName, targetName, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return products[mid];
            else if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main(string[] args)
    {
        // Step 2: Create sample product data
        Product[] products = {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Mobile", "Electronics"),
            new Product(103, "Shampoo", "Personal Care"),
            new Product(104, "Notebook", "Stationery"),
            new Product(105, "Pen", "Stationery")
        };

        // Step 3.3: Sort products by name for binary search
        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

        // Test Linear Search
        string searchTerm = "Mobile";
        Product foundLinear = LinearSearch(products, searchTerm);
        Console.WriteLine("\n--- Linear Search ---");
        Console.WriteLine(foundLinear != null
            ? $"Product found: {foundLinear.ProductName} (ID: {foundLinear.ProductId})"
            : "Product not found.");

        // Test Binary Search
        Product foundBinary = BinarySearch(products, searchTerm);
        Console.WriteLine("\n--- Binary Search ---");
        Console.WriteLine(foundBinary != null
            ? $"Product found: {foundBinary.ProductName} (ID: {foundBinary.ProductId})"
            : "Product not found.");
    }
}
