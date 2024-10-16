class main
{
    static void Main(string[] args)
    {
        int win = 0;
        int lose = 0;
        int ch = 0;
        while (ch != 4)
        {

            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить победу ");
            Console.WriteLine("2. Добавить поражение");
            Console.WriteLine("3. Подсчитать процент побед");
            Console.WriteLine("4. Выход");
            Console.WriteLine("Выберите действие: ");

            ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                win++;
                Console.WriteLine($"Добавлена 1 победа");
            }
            if (ch == 2)
            {
                lose++;
                Console.WriteLine($"Добавлено 1 поражение");
            }
            if (ch == 3)
            { 
                double winrate = (double)win / (win + lose) * 100; 
                Console.WriteLine($"Количество побед: {win}");
                Console.WriteLine($"Количество поражений: {lose}");
                Console.WriteLine($"Процент побед: {winrate}%");
            }
            if (ch == 4)
            {
                Console.WriteLine("Выход");
            }
        }
    }
}