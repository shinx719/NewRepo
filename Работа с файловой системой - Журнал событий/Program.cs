using System;
class userLog
{
    static void Main()
    {
        string filePath = "log.txt";
        string eventMessage = $"Пользователь зашел в - {DateTime.Now}";
        File.AppendAllText(filePath, $"{eventMessage}\n");
        string logContent = File.ReadAllText(filePath);
        Console.WriteLine("Журнал событий:");
        Console.WriteLine(logContent);
        if (File.Exists(filePath))
        {
            Console.WriteLine("Файл журнала существует и обновлён.");
        }
    }
}
