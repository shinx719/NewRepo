class main
{
    static void Main(string[] args)
    {

        Order order1 = new Order();
        order1.orderName = "Рис";
        order1.orderCount = 0;
        order1.orderPrice = 100;

        Order order2 = new Order();
        order2.orderName = "Суп";
        order2.orderCount = 0;
        order2.orderPrice = 200;

        Order order3 = new Order();
        order3.orderName = "Стейк ";
        order3.orderCount = 0;
        order3.orderPrice = 500;


        int ch = 0;
        while (ch != 5)
        {

            Console.WriteLine("Меню:");
            Console.WriteLine("1. Вывести все меню: ");
            Console.WriteLine("2. Сделать заказ");
            Console.WriteLine("3. Дополнить заказ");
            Console.WriteLine("4. Выставить счёт");
            Console.WriteLine("5. Выход");
            Console.WriteLine("Выберите действие: ");

            ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine($"1.{order1.orderName} цена {order1.orderPrice} c." +
                    $"\n2.{order2.orderName} цена {order2.orderPrice} c." +
                    $"\n3.{order3.orderName}цена {order3.orderPrice} c.");
            }

            if (ch == 2)
            {
                int cho = 0;
                while (cho != 4)
                {
                    Console.WriteLine("Меню:");
                    Console.WriteLine("1. Порция риса");
                    Console.WriteLine("2. Куриный суп");
                    Console.WriteLine("3. Стейк");
                    Console.WriteLine("4. Вернуться назад");
                    Console.WriteLine("Выберите действие: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        Console.WriteLine($"Ваш заказ: {order1.orderName}");
                    }
                    if (cho == 2)
                    {
                        Console.WriteLine($"Ваш заказ: {order2.orderName}");
                    }
                    if (cho == 3)
                    {
                        Console.WriteLine($"Ваш заказ: {order3.orderName}");
                    }
                    if (cho == 4)
                    {
                        Console.WriteLine("Возвращаемся в главное меню...");
                    }
                }
               
            }

            if (ch == 3)
            {
                int cho = 0;
                while (cho != 4)
                {
                    Console.WriteLine("Меню для добавления:");
                    Console.WriteLine("1. Порция риса");
                    Console.WriteLine("2. Куриный суп");
                    Console.WriteLine("3. Стейк");
                    Console.WriteLine("4. Вернуться назад");
                    Console.WriteLine("Выберите действие: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        order1.orderCount++;
                        Console.WriteLine($"Добавлена порция: {order1.orderName}");
                    }
                    if (cho == 2)
                    {
                        order2.orderCount++;
                        Console.WriteLine($"Добавлена порция: {order2.orderName}");
                    }
                    if (cho == 3)
                    {
                        order3.orderCount++;
                        Console.WriteLine($"Добавлена порция: {order3.orderName}");
                    }
                    else if (cho == 4)
                    {
                        Console.WriteLine("Возвращаемся в главное меню...");
                    }
                }

            }

            if (ch == 4)
            {
                int total = (order1.orderCount * order1.orderPrice) +
                   (order2.orderCount * order2.orderPrice) +
                   (order3.orderCount * order3.orderPrice);

                Console.WriteLine("Ваш счёт:");
                if (order1.orderCount > 0)
                    Console.WriteLine($"{order1.orderCount * order1.orderPrice} c.");
                if (order2.orderCount > 0)
                    Console.WriteLine($"{order2.orderCount * order2.orderPrice} c.");
                if (order3.orderCount > 0)
                    Console.WriteLine($"{order3.orderCount * order3.orderPrice} c.");

                Console.WriteLine($"Общая сумма: {total} c.");
            }

            if (ch == 5)
            {
                Console.WriteLine($"Выход");
            }
        }
    }
}