using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string filePath = "log.txt";
        try {
            Console.WriteLine("Напишите, какой отчет надо загрузить:");
            string reportData = Console.ReadLine();
            Console.WriteLine("Начинается загрузка отчета...");
            await Task.Delay(4000);
            await File.AppendAllTextAsync(filePath, $"{reportData}\n");
            Console.WriteLine($"Отчет сохранен в файл: {filePath}");
            Console.WriteLine("Загрузка отчета завершена.");
            Console.ReadLine();
        }
        catch (Exception ex) { 
            Console.WriteLine($"Ошибка: {ex.Message}"); 
        }
    }
}
 