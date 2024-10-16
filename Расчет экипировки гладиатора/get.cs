public abstract class Armor
{
    int armorWeight = 0;
    int armorCost = 0;
    int weaponWeight = 0;
    int weaponCost = 0;
    int extraArmorWeight = 0;
    int extraArmorCost = 0;
    public async void chooseArmor()
    {
        int cho = 0;
        Console.WriteLine("Меню");
        Console.WriteLine("1.Легкие доспехи");
        Console.WriteLine("2.Средние доспехи");
        Console.WriteLine("3.Тяжелые доспехи");

        cho = Convert.ToInt32(Console.ReadLine());
        if (cho >= 1 && cho <= 3)
        {
            Console.WriteLine("Введите вес брони");
            int inputWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите его стоимость");
            int inputCost = Convert.ToInt32(Console.ReadLine());
            weaponWeight = inputWeight;
            weaponCost = inputCost;
        }

    }
    public void chooseWeapon()
    {
        int cho = 0;
        Console.WriteLine("Меню");
        Console.WriteLine("1.Меч");
        Console.WriteLine("2.Трезубец");
        Console.WriteLine("3.Копье");
        cho = Convert.ToInt32(Console.ReadLine());
        if (cho >= 1 && cho <= 3)
        {
            Console.WriteLine("Введите вес оружия");
            int inputWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите его стоимость");
            int inputCost = Convert.ToInt32(Console.ReadLine());
            weaponWeight = inputWeight;
            weaponCost = inputCost;
        }
    }
    public void chooseExtraArmor()
    {
        int cho = 0;
        Console.WriteLine("Меню доп. защиты");
        Console.WriteLine("1.Шлем");
        Console.WriteLine("2.Щит");
        cho = Convert.ToInt32(Console.ReadLine());
        if (cho >= 1 && cho <= 2)
        {
            Console.WriteLine("Введите вес защиты");
            int inputWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите его стоимость");
            int inputCost = Convert.ToInt32(Console.ReadLine());
            weaponWeight = inputWeight;
            weaponCost = inputCost;
        }
    }
    public async void countTotal()
    {
        int totalWeight = armorWeight + weaponWeight + extraArmorWeight;
                int totalCost = armorCost + weaponCost + extraArmorCost;
                Console.WriteLine($"Вес всего снаряжения {totalWeight}" +
                    $"\nСтоимость {totalCost}");
    }
    
   
}