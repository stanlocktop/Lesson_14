using System;
using System.Collections.Generic;

class Cart
{
    private List<Product> cartItems = new List<Product>();

    // ��������� �������� �� ������ �볺���.
    public void AddToCart(Product product)
    {
        cartItems.Add(product);
    }

    // ��������� �������� � ������ �� ���������������.
    public void RemoveFromCart(int productId)
    {
        cartItems.RemoveAll(product => product.Id == productId);
    }

    // ���������� �������� ���� ��� �������� � ������ �볺���.
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