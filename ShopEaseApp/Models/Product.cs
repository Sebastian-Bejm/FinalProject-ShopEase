namespace ShopEaseApp.Models;

public class Product {
    public int ProductID {get; set;}
    public string Name {get; set;} = string.Empty;
    public decimal Price {get; set;}
    public string Category {get; set;} = string.Empty;

    public string GetProductDetails() {
        return "Product: " + Name + " | Price: " + Price.ToString("0.##") + " | Category: " + Category;
    }
}
