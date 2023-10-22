using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode; 
        Queue<Order> orderQueue = new Queue<Order>();
        int processedOrders = 0;
        double totalProcessedAmount = 0.0;

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Додати замовлення");
            Console.WriteLine("2. Обробити замовлення");
            Console.WriteLine("3. Вивести інформацію про чергу");
            Console.WriteLine("4. Вийти");

            Console.Write("Виберіть опцію: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Додавання замовлення до черги
                Console.Write("Введіть номер замовлення: ");
                int orderNumber = int.Parse(Console.ReadLine());
                Console.Write("Введіть ім'я клієнта: ");
                string customerName = Console.ReadLine();
                Console.Write("Введіть загальну суму замовлення: ");
                double totalAmount = double.Parse(Console.ReadLine());

                Order newOrder = new Order
                {
                    OrderNumber = orderNumber,
                    CustomerName = customerName,
                    TotalAmount = totalAmount
                };

                orderQueue.Enqueue(newOrder);
                Console.WriteLine("Замовлення додано до черги.");
            }
            else if (choice == "2")
            {
                // Обробка замовлення
                if (orderQueue.Count > 0)
                {
                    Order processedOrder = orderQueue.Dequeue();
                    Console.WriteLine($"Оброблено замовлення {processedOrder.OrderNumber} для {processedOrder.CustomerName} на суму ${processedOrder.TotalAmount}");
                    processedOrders++;
                    totalProcessedAmount += processedOrder.TotalAmount;
                }
                else
                {
                    Console.WriteLine("Черга порожня. Замовлень для обробки немає.");
                }
            }
            else if (choice == "3")
            {
                // Виведення інформації про чергу
                Console.WriteLine("Замовлення в черзі:");
                foreach (var order in orderQueue)
                {
                    Console.WriteLine($"Замовлення {order.OrderNumber} для {order.CustomerName} на суму ${order.TotalAmount}");
                }
                Console.WriteLine($"Загальна кількість оброблених замовлень: {processedOrders}");
                Console.WriteLine($"Загальна сума оброблених замовлень: ${totalProcessedAmount}");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Програма завершила роботу.");
                break;
            }
            else
            {
                Console.WriteLine("Невірний вибір. Будь ласка, виберіть одну з опцій меню.");
            }
            Console.ReadKey();
        }
    }
}