using System;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Введите количество дней аренды:");
        int rentalDays = Convert.ToInt32(await Task.Run(() => Console.ReadLine()));

        Console.WriteLine("Выберите тип снаряжения: 1 - Лыжи, 2 - Сноуборд:");
        int equipmentChoice = Convert.ToInt32(await Task.Run(() => Console.ReadLine()));

        Console.WriteLine("Добавить страховку? (1 - Да, 2 - Нет):");
        bool hasInsurance = Convert.ToInt32(await Task.Run(() => Console.ReadLine())) == 1;

        RentalEquipment equipment = null;
        if (equipmentChoice == 1)
        {
            equipment = new Ski();
        }
        else if (equipmentChoice == 2)
        {
            equipment = new Snowboard();
        }
        equipment.RentalDays = rentalDays;
        equipment.HasInsurance = hasInsurance;

        double totalPrice = equipment.calculateTotalPrice();

        Console.WriteLine($"Итоговая стоимость аренды: {totalPrice} с.");
        Console.ReadLine();
    }
}
