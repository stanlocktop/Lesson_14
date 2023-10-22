using System;
using System.Collections.Generic;

class Shop
{
    private List<Product> availableProducts = new List<Product>();

    // Додавання продукту до асортименту магазину.
    public void AddProduct(Product product)
    {
        availableProducts.Add(product);
    }

    // Видалення продукту за ідентифікатором.
    public void RemoveProduct(int productId)
    {
        availableProducts.RemoveAll(product => product.Id == productId);
    }

    // Отримання продукту за ідентифікатором.
    public Product GetProductById(int productId)
    {
        return availableProducts.Find(product => product.Id == productId);
    }

    // Отримання списку всіх доступних продуктів.
    public List<Product> GetAllProducts()
    {
        return availableProducts;
    }
}