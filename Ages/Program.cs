using System;

abstract class Human
{
    public int age { get; set; }

    protected async Task Delay()
    {
        Console.WriteLine("Идут подсчеты...");
        await Task.Delay(1000);
    }

    public abstract Task printAge();  
}
class Child : Human
{
    public override async Task printAge()
    {
        await Delay();
        Console.WriteLine("Вы находитесь в периоде детства");
        Console.WriteLine("Основное внимание должно быть направлено на физическое здоровье " +
            "ребенка: правильное питание, регулярные осмотры у педиатра, прививки.");
    }
}
class Tenager : Human
{
    public override async Task printAge()
    {
        await Delay();
        Console.WriteLine("Подростковый возраст");
        Console.WriteLine("Это время эмоциональных качелей и поиска идентичности. " +
            "Подростки нуждаются в понимании и принятии. Создавайте условия для открытого диалога, " +
            "уважайте их мнение, помогайте справляться с трудностями. ");
    }
}
class Adult : Human
{
    public override async Task printAge()
    {
        await Delay();
        Console.WriteLine("Взрослая жизнь");
        Console.WriteLine("Молодость: 18–35 лет. Период, когда человек активно строит карьеру, " +
            "ищет и формирует долгосрочные отношения, обзаводится семьей. Пик физической активности." +
            "\nСредний возраст: 35–60 лет. Период стабильности, достижения жизненных целей, " +
            "профессиональных высот. Часто появляется осознание ограниченности времени, могут возникать кризисы среднего возраста.");
    }
}
class Old : Human
{
    public override async Task printAge()
    {
        await Delay();
        Console.WriteLine("Старость");
        Console.WriteLine("Период завершения профессиональной деятельности и выхода на пенсию. " +
            "Может наблюдаться снижение физической активности, но сохраняется социальная и умственная активность.");
    }
}

class MainClass
{
    static async Task Main(string[] args)
    {
        Console.Write("Введите свой возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваш возраст: " + age);
        Human human = Ages.getAge(age);
        human.age = age;
        await human.printAge();
        Console.ReadLine();
    }
}
class Ages
{ 
    public static Human getAge(int age)
    { 
        if (age <= 12)
        {
            return new Child();
        }
        else if (age >= 12 && age <= 18)
        {
            return new Tenager();
        }
        else if (age >= 18 && age <= 60)
        {
            return new Adult();
        }    
        else 
        {
            return new Old();
        }
    }
}
