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
        Console.WriteLine("����");
        Console.WriteLine("1.������ �������");
        Console.WriteLine("2.������� �������");
        Console.WriteLine("3.������� �������");

        cho = Convert.ToInt32(Console.ReadLine());
        if (cho >= 1 && cho <= 3)
        {
            Console.WriteLine("������� ��� �����");
            int inputWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� ��� ���������");
            int inputCost = Convert.ToInt32(Console.ReadLine());
            weaponWeight = inputWeight;
            weaponCost = inputCost;
        }

    }
    public void chooseWeapon()
    {
        int cho = 0;
        Console.WriteLine("����");
        Console.WriteLine("1.���");
        Console.WriteLine("2.��������");
        Console.WriteLine("3.�����");
        cho = Convert.ToInt32(Console.ReadLine());
        if (cho >= 1 && cho <= 3)
        {
            Console.WriteLine("������� ��� ������");
            int inputWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� ��� ���������");
            int inputCost = Convert.ToInt32(Console.ReadLine());
            weaponWeight = inputWeight;
            weaponCost = inputCost;
        }
    }
    public void chooseExtraArmor()
    {
        int cho = 0;
        Console.WriteLine("���� ���. ������");
        Console.WriteLine("1.����");
        Console.WriteLine("2.���");
        cho = Convert.ToInt32(Console.ReadLine());
        if (cho >= 1 && cho <= 2)
        {
            Console.WriteLine("������� ��� ������");
            int inputWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� ��� ���������");
            int inputCost = Convert.ToInt32(Console.ReadLine());
            weaponWeight = inputWeight;
            weaponCost = inputCost;
        }
    }
    public async void countTotal()
    {
        int totalWeight = armorWeight + weaponWeight + extraArmorWeight;
                int totalCost = armorCost + weaponCost + extraArmorCost;
                Console.WriteLine($"��� ����� ���������� {totalWeight}" +
                    $"\n��������� {totalCost}");
    }
    
   
}