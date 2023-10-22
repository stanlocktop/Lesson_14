using System;
using System.Collections.Generic;

class Cart
{
    private List<Product> cartItems = new List<Product>();

    // Додавання продукту до кошика клієнта.
    public void AddToCart(Product product)
    {
        cartItems.Add(product);
    }

    // Видалення продукту з кошика за ідентифікатором.
    public void RemoveFromCart(int productId)
    {
        cartItems.RemoveAll(product => product.Id == productId);
    }

    // Розрахунок загальної ціни всіх продуктів в кошику клієнта.
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var item in cartItems)
        {
            total += item.Price;
        }
        return total;
    }
}