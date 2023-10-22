using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();
        Cart cart = new Cart();
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        shop.AddProduct(new Product(1, "Ковбаса", 49.99));
        shop.AddProduct(new Product(2, "Сир", 45.99));
        shop.AddProduct(new Product(3, "Хліб", 12.55));

        while (true)
        {
            Console.WriteLine("Доступні продукти:");
            foreach (var product in shop.GetAllProducts())
            {
                Console.WriteLine($"{product.Id}. {product.Name} - {product.Price} грн");
            }

            Console.WriteLine("Кошик:");
            foreach (var cartItem in cart.GetCartItems())
            {
                Console.WriteLine($"{cartItem.Name} - {cartItem.Price} грн");
            }
            Console.WriteLine("Загальна вартість кошика: " + cart.GetTotalPrice());

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