public class Mainclass : Armor
{
    static async void Main(string[] args)
    {
        
        int ch = 0;
        while (ch != 5)
        {
            
            Console.WriteLine("1.Выбрать тип доспеха");
            Console.WriteLine("2.Выбрать тип оружия");
            Console.WriteLine("3.Выбрать дополнительную защиту");
            Console.WriteLine("4.Вывести общий вес снаряжения и его стоимость");
            Console.WriteLine("5. Выход");
            ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                chooseArmor;
                
            }
            if (ch == 2)
            {
                chooseWeapon;
            }
            if (ch == 3)
            {
                chooseExtraArmor;
            }
            if (ch == 4)
            {
                countTotal;
            }

            else if (ch != 5)
            {
                Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
            }
        }
        Console.WriteLine("Завершение работы");
    }
}