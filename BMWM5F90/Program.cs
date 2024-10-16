using System;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите средний расход топлива на 100км");
        double averageFuelConsumption = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Среднюю цену за литр бензина");
        double averageGasolinePrice = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Годовой пробег");
        double annualMileage = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Стоимость страховки");
        double insuranceCost = Convert.ToDouble(Console.ReadLine());
        double total = (averageFuelConsumption * (annualMileage/100) * averageGasolinePrice + insuranceCost);
        Console.WriteLine($"Стоимость владения BMW M5 F90 за год равна: {total} c.");
    }
}