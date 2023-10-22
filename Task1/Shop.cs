using System;
using System.Collections.Generic;

class Shop
{
    private List<Product> availableProducts = new List<Product>();

    public void AddProduct(Product product)
    {
        availableProducts.Add(product);
    }

    public void RemoveProduct(int productId)
    {
        availableProducts.RemoveAll(product => product.Id == productId);
    }

    public Product GetProductById(int productId)
    {
        return availableProducts.Find(product => product.Id == productId);
    }

    public List<Product> GetAllProducts()
    {
        return availableProducts;
    }
}