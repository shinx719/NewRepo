Console.Write("Введите свои ежемесячные расходы на аренду");
    int arenda = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите свои ежемесячные расходы на еду");
    int food = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите свои ежемесячные расходы на проезд");
    int car = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите свои проиче расходы");
    int other = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ваш ежемесячный доход");
    int dox = Convert.ToInt32(Console.ReadLine());

    int ras = arenda + food + car + other;

    int ost = dox - ras;

Console.WriteLine($"Расходы {ras}");

Console.WriteLine($"Остаток {ost}");

if (dox < ras) {
    int ost1 = (ost*-1);
    Console.WriteLine($"Расход превысил доход на {ost1}");
}