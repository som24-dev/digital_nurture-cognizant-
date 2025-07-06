using System.Collections.Generic;

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = null!;
    public List<Product> Products { get; set; } = new();
}
