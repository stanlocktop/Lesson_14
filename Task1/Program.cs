using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();

        // Додавання продуктів до асортименту магазину
        shop.AddProduct(new Product(1, "Product A", 10.99));
        shop.AddProduct(new Product(2, "Product B", 5.99));
        shop.AddProduct(new Product(3, "Product C", 7.49));

        Cart cart = new Cart();

        // Додавання продуктів до кошика клієнта
        cart.AddToCart(shop.GetProductById(1));
        cart.AddToCart(shop.GetProductById(3));

        // Виведення загальної ціни продуктів у кошику клієнта
        Console.WriteLine("Загальна вартість продуктів у кошику: " + cart.GetTotalPrice());
        Console.ReadKey();
    }
}