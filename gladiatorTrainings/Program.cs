using System;
class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество часов тренировок в день: ");
        int hoursTraining = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите дни недели тренировок");
        String trainingDays = Console.ReadLine();
        int countWords = trainingDays.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        int totalHours = hoursTraining * countWords;
      

        int ch = 0;
        
            Console.WriteLine("Выберите тип тренировки");
            Console.WriteLine("1. Бой с мечом");
            Console.WriteLine("2. Бег");
            Console.WriteLine("3. Силовые упражнения");
            ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("Рекомендации к востановлению:");
                Console.WriteLine("Отдых и гидратация: " +
                    "\nПозвольте телу отдохнуть, пейте много воды и включите в рацион богатую белками и витаминами пищу");
               
            }
        if (ch == 2)
        {
            Console.WriteLine("Рекомендации к востановлению:");
            Console.WriteLine("Медленный бег или ходьба: " +
                "\nПосле основной части тренировки проведите 5–10 минут в медленном темпе, " +
                "чтобы снизить частоту сердечных сокращений и подготовить мышцы к восстановлению.");

        }
        if (ch == 3)
        {
            Console.WriteLine("Рекомендации к востановлению:");
            Console.WriteLine("Легкие кардио: " +
                "\nПроведите 5–10 минут после тренировки, выполняя лёгкое кардио (например, ходьба или лёгкий бег), " +
                "чтобы снизить пульс и помочь организму вернуться в спокойное состояние.");

        }

        Console.WriteLine($"Количество проведенных часов в неделю за тренировкой - {totalHours}");

    }
}