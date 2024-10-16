using System;
class Program
{
    static async Task Main()
    {
        try
        {
            double input = 0;
            double price = 0;
            int ch = 0;
            while (ch != 1)
            {
                try
                {
                    Console.WriteLine("Введите количество товара:");
                    string count = Console.ReadLine();

                    if (!double.TryParse(count, out input) || input < 0)
                    {
                        throw new Exception("Количество товара должно быть положительным числом!");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            while (ch != 1)
            {
                try
                {
                    Console.WriteLine("Введите цену товара:");
                    string priceInput = Console.ReadLine();

                    if (!double.TryParse(priceInput, out price) || price < 0)
                    {
                        throw new Exception("Цена товара должна быть положительной!");
                    }

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            Console.WriteLine("Идет подсчет стоимости...");
            await Task.Delay(2000);
            double total = price * input;
            Console.WriteLine($"Общая стоимость товара: {total} с.");
            Console.ReadLine();
        }

        finally
        {
            Console.WriteLine("Выход.");
        }
    }
}