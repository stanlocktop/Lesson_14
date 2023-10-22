using System;
using System.Collections.Generic;

class Cart
{
    private List<Product> cartItems = new List<Product>();

    public void AddToCart(Product product)
    {
        cartItems.Add(product);
    }

    public void RemoveFromCart(int productId)
    {
        cartItems.RemoveAll(product => product.Id == productId);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var item in cartItems)
        {
            total += item.Price;
        }
        return total;
    }

    public List<Product> GetCartItems()
    {
        return cartItems;
    }
}