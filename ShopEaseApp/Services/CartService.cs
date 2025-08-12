using ShopEaseApp.Models;

namespace ShopEaseApp.Services;

public class CartService {
    private List<Product> cart = new();

    public IReadOnlyList<Product> CartItems => cart;

    public void AddProduct(Product product) {
        cart.Add(product);
    }

    public void RemoveProduct(int productId) {
        var product = cart.FirstOrDefault(p => p.ProductID == productId);
        if (product != null) {
            cart.Remove(product);
        }
    }

    public void SetProductQuantity(Product product, int quantity) {
        cart.RemoveAll(p => p.ProductID == product.ProductID);

        for (int i = 0; i < quantity; i++) {
            cart.Add(new Product{
                ProductID = product.ProductID,
                Name = product.Name,
                Price = product.Price,
                Category = product.Category
            });
        }
    }

    public decimal CalculateTotal()
    {
        return cart.Sum(p => p.Price);
    }
}
