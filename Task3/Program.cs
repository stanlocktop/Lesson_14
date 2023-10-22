using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Додати контакт");
            Console.WriteLine("2. Видалити контакт");
            Console.WriteLine("3. Пошук контакту");
            Console.WriteLine("4. Вивести всі контакти");
            Console.WriteLine("5. Вийти");

            Console.Write("Виберіть опцію: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Додавання нового контакту
                    Console.Write("Введіть ім'я контакту: ");
                    string name = Console.ReadLine();
                    Console.Write("Введіть номер телефону: ");
                    string phoneNumber = Console.ReadLine();

                    if (!contacts.ContainsKey(name))
                    {
                        contacts[name] = phoneNumber;
                        Console.WriteLine("Контакт додано.");
                    }
                    else
                    {
                        Console.WriteLine("Контакт з таким іменем вже існує.");
                    }
                    break;

                case "2":
                    // Видалення контакту
                    Console.Write("Введіть ім'я контакту для видалення: ");
                    string contactName = Console.ReadLine();

                    if (contacts.ContainsKey(contactName))
                    {
                        contacts.Remove(contactName);
                        Console.WriteLine("Контакт видалено.");
                    }
                    else
                    {
                        Console.WriteLine("Контакт не знайдено.");
                    }
                    break;

                case "3":
                    // Пошук контакту
                    Console.Write("Введіть ім'я контакту для пошуку: ");
                    string searchName = Console.ReadLine();

                    if (contacts.ContainsKey(searchName))
                    {
                        Console.WriteLine($"Номер телефону для {searchName}: {contacts[searchName]}");
                    }
                    else
                    {
                        Console.WriteLine("Контакт не знайдено.");
                    }
                    break;

                case "4":
                    // Виведення всіх контактів
                    Console.WriteLine("Всі контакти:");
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine($"{contact.Key}: {contact.Value}");
                    }
                    break;

                case "5":
                    // Вихід з програми
                    Console.WriteLine("Програма завершила роботу.");
                    return;

                default:
                    Console.WriteLine("Невірний вибір. Будь ласка, виберіть одну з опцій меню.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
