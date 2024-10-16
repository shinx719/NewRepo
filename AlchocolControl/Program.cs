using System;
abstract class Alcohol
{
    public int Count { get; set; }
    protected async Task Delay()
    {
        Console.WriteLine("Идут подсчеты...");
        await Task.Delay(3000);
    }

    public abstract Task AlcoholInfo();
}
class Beer : Alcohol
{
    public override async Task AlcoholInfo()
    {
        await Delay();
        Console.WriteLine($"Вы выпили {Count} порций пива.");
    }
}
class Wine : Alcohol
{
    public override async Task AlcoholInfo()
    {
        Console.WriteLine($"Вы выпили {Count} порций вина.");
    }
}
class Vodka : Alcohol
{
    public override async Task AlcoholInfo()
    {
        Console.WriteLine($"Вы выпили {Count} порций водки.");
    }
}

class MainClass
{
    static async Task Main(string[] args)
    {
        int beerCount = 0;
        int wineCount = 0;
        int vodkaCount = 0;
        int ch = 0;

        while (ch != 3)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Выбрать тип напитка");
            Console.WriteLine("2. Подсчитать количество выпитого алкоголя");
            Console.WriteLine("3. Выход");
            Console.WriteLine("Выберите действие: ");

            ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                int cho = 0;
               
                    Console.WriteLine("Выберите тип напитка");
                    Console.WriteLine("1. Пиво");
                    Console.WriteLine("2. Вино");
                    Console.WriteLine("3. Водка");
                    Console.WriteLine("Выберите действие: ");

                    cho = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (cho == 1)
                    {
                        Console.WriteLine("Введите количество порций пива:");
                        beerCount += Convert.ToInt32(Console.ReadLine());
                    }
                    else if (cho == 2)
                    {
                        Console.WriteLine("Введите количество порций вина:");
                        wineCount += Convert.ToInt32(Console.ReadLine());
                    }
                    else if (cho == 3)
                    {
                        Console.WriteLine("Введите количество порций водки:");
                        vodkaCount += Convert.ToInt32(Console.ReadLine());

                    }
            }
            else if (ch == 2)
            {
                double totalAlcohol = (beerCount * 330 * 0.05 * 0.789) + // Пиво (330 мл, 5%)
                                    (wineCount * 150 * 0.13 * 0.789) + // Вино (150 мл, 13%)
                                    (vodkaCount * 50 * 0.40 * 0.789);   // Водка (50 мл, 40%)

                double safeLimit = 30.0;

                Console.WriteLine($"Общее количество выпитого алкоголя: {totalAlcohol} грамм");
 
                if (((beerCount * 20.0) + (wineCount * 10.0) + (vodkaCount * 15.0)) > safeLimit)
                {
                    Console.WriteLine("Внимание! Превышение безопасной нормы!");
                }
            }
            else 
            {
                Console.WriteLine("Выход из программы");
            }

            
        }
        Alcohol beer = new Beer { Count = beerCount };
        Alcohol wine = new Wine { Count = wineCount };
        Alcohol vodka = new Vodka { Count = vodkaCount };

        await beer.AlcoholInfo();
        await wine.AlcoholInfo();
        await vodka.AlcoholInfo();

        Console.ReadLine();
    }
}
