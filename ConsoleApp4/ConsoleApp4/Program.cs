using System;

namespace Lab2_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторна робота №2";
            ShowMenu();
        }

        // ===== ГОЛОВНЕ МЕНЮ =====
        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("===== ГОЛОВНЕ МЕНЮ =====");
            Console.WriteLine("1. Перегляд товарів");
            Console.WriteLine("2. Розрахунок покупки");
            Console.WriteLine("3. Інформація про магазин");
            Console.WriteLine("4. Налаштування");
            Console.WriteLine("0. Вихід");
            Console.Write("\nВаш вибір: ");

            try
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowProducts();
                        break;
                    case 2:
                        CalculatePurchase();
                        break;
                    case 3:
                        ShowInfo();
                        break;
                    case 4:
                        Settings();
                        break;
                    case 0:
                        ExitProgram();
                        return;
                    default:
                        Console.WriteLine("❌ Невірний пункт меню!");
                        Pause();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("❌ Помилка! Введіть число.");
                Pause();
            }

            // рекурсивне повернення до меню
            ShowMenu();
        }

        // ===== ПУНКТИ МЕНЮ =====

        static void ShowProducts()
        {
            Console.Clear();
            Console.WriteLine("=== СПИСОК ТОВАРІВ ===");
            Console.WriteLine("1. Хліб - 25 грн");
            Console.WriteLine("2. Молоко - 40 грн");
            Console.WriteLine("3. Сир - 120 грн");
            Pause();
        }

        static void CalculatePurchase()
        {
            Console.Clear();
            Console.WriteLine("=== РОЗРАХУНОК ПОКУПКИ ===");

            try
            {
                Console.Write("Введіть ціну товару: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Введіть кількість: ");
                int amount = int.Parse(Console.ReadLine());

                double total = price * amount;

                Console.WriteLine($"Загальна сума: {total} грн");
            }
            catch
            {
                Console.WriteLine("❌ Помилка введення даних!");
            }

            Pause();
        }

        static void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("=== ІНФОРМАЦІЯ ПРО МАГАЗИН ===");
            Console.WriteLine("Назва: Demo Store");
            Console.WriteLine("Адреса: м. Київ");
            Console.WriteLine("Телефон: +380000000000");
            Pause();
        }

        static void Settings()
        {
            Console.Clear();
            Console.WriteLine("=== НАЛАШТУВАННЯ ===");
            Console.WriteLine("Функція в розробці...");
            Pause();
        }

        static void ExitProgram()
        {
            Console.Clear();
            Console.WriteLine("Дякуємо за використання програми!");
            Pause();
        }

        // ===== ДОПОМІЖНА ФУНКЦІЯ =====
        static void Pause()
        {
            Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
            Console.ReadKey();
        }
    }
}
