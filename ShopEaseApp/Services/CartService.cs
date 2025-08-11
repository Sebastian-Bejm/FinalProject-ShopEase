using ShopEaseApp.Models;

namespace ShopEaseApp.Services;

public class CartService
{
    private List<Product> cart = new();

    public IReadOnlyList<Product> CartItems => cart;

    public void AddProduct(Product product)
    {
        cart.Add(product);
    }

    public void RemoveProduct(int productId)
    {
        cart.RemoveAll(p => p.ProductID == productId);
    }

    public decimal CalculateTotal()
    {
        return cart.Sum(p => p.Price);
    }
}
