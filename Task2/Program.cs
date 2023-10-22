using System;
using System.Collections.Generic;

class Product
{
    public int Id { get; }
    public string Name { get; }
    public double Price { get; }

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

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

class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();
        Cart cart = new Cart();

        shop.AddProduct(new Product(1, "Product A", 10.99));
        shop.AddProduct(new Product(2, "Product B", 5.99));
        shop.AddProduct(new Product(3, "Product C", 7.49));

        while (true)
        {
            Console.WriteLine("Доступні продукти:");
            foreach (var product in shop.GetAllProducts())
            {
                Console.WriteLine($"{product.Id}. {product.Name} - ${product.Price}");
            }

            Console.WriteLine("Кошик:");
            foreach (var cartItem in cart.GetCartItems())
            {
                Console.WriteLine($"{cartItem.Name} - ${cartItem.Price}");
            }
            Console.WriteLine("Загальна вартість кошика: $" + cart.GetTotalPrice());

            Console.WriteLine("Меню:");
            Console.WriteLine("1. Додати продукт в кошик");
            Console.WriteLine("2. Видалити продукт з кошика");
            Console.WriteLine("3. Завершити покупку");

            Console.Write("Виберіть дію (1/2/3): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Введіть ідентифікатор продукту для додавання до кошика: ");
                if (int.TryParse(Console.ReadLine(), out int productId))
                {
                    Product product = shop.GetProductById(productId);
                    if (product != null)
                    {
                        cart.AddToCart(product);
                        Console.WriteLine($"{product.Name} додано до кошика.");
                    }
                    else
                    {
                        Console.WriteLine("Продукт з введеним ідентифікатором не знайдено.");
                    }
                }
                else
                {
                    Console.WriteLine("Невірний формат ідентифікатора продукту.");
                }
            }
            else if (choice == "2")
            {
                Console.Write("Введіть ідентифікатор продукту для видалення з кошика: ");
                if (int.TryParse(Console.ReadLine(), out int productId))
                {
                    Product product = cart.GetCartItems().Find(item => item.Id == productId);
                    if (product != null)
                    {
                        cart.RemoveFromCart(productId);
                        Console.WriteLine($"{product.Name} видалено з кошика.");
                    }
                    else
                    {
                        Console.WriteLine("Продукт з введеним ідентифікатором не знайдено в кошику.");
                    }
                }
                else
                {
                    Console.WriteLine("Невірний формат ідентифікатора продукту.");
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("Завершено оформлення покупки.");
                break;
            }
            else
            {
                Console.WriteLine("Невірний вибір. Виберіть один з варіантів меню.");
            }
            Console.ReadKey();
        }
    }
}
