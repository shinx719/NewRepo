using System;
using System.Collections.Generic;

class MainClass
{
    static void Main(string[] args)
    {
        List<Client> clients = new List<Client>();
        string clientName = null;
        string ch = "";

        while (ch != "exit")
        {
            Console.WriteLine("Введите имя клиента (или 'exit' для выхода):");
            clientName = Console.ReadLine();

            if (clientName.ToLower() == "exit")
            {
                break;
            }
            Console.WriteLine("Введите услуги (через запятую):");
            string servicesInput = Console.ReadLine();
            string services = servicesInput;
            Console.WriteLine("Введите общую сумму оплаты:");
            int amount = Convert.ToInt32(Console.ReadLine());
         
            clients.Add(new Client(clientName, services, amount));

            Console.WriteLine("Клиент добавлен!");
        }

        Console.WriteLine("\nСписок клиентов за день:");
        foreach (var client in clients)
        {
            Console.WriteLine($"Имя: {client.Name}, Услуги: {client.Services}, Сумма оплаты: {client.Amount} c.");
            
        }
        Console.ReadLine();
    }
}
