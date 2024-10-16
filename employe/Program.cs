class main
{
    static void Main(string[] args)
    {

        Employee employee1 = new Employee();
        employee1.employeeName = "Анна Ивановка";
        employee1.employeJobTitle = "Маркетолог";
        employee1.salary = 120000;

        Employee employee2 = new Employee();
        employee2.employeeName = "Сергей Петров";
        employee2.employeJobTitle = "Программист";
        employee2.salary = 200000;

        Employee employee3 = new Employee();
        employee3.employeeName = "Ольга Смирнова";
        employee3.employeJobTitle = "Финансовый аналитик";
        employee3.salary = 150000;


        int ch = 0;
        while (ch != 5)
        {

            Console.WriteLine("Меню:");
            Console.WriteLine("1. Вывести данные о сотрудниках ");
            Console.WriteLine("2. Повысить зарплату");
            Console.WriteLine("3. Понизить зарплату");
            Console.WriteLine("4. Изменить должность сотрудника");
            Console.WriteLine("5. Выход");
            Console.WriteLine("Выберите действие: ");

            ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine($"1.{employee1.employeeName}, должность {employee1.employeJobTitle} зарплата {employee1.salary} " +
                    $"\n2.{employee2.employeeName}, должность {employee2.employeJobTitle} зарплата {employee2.salary} " +
                    $"\n3.{employee3.employeeName}, должность {employee3.employeJobTitle} зарплата {employee3.salary}");
            }

            if (ch == 2)
            {
                int cho = 0;
                while (cho != 5)
                {
                    Console.WriteLine("Выберите кому повысить зарплату");
                    Console.WriteLine($"1.{employee1.employeeName}");
                    Console.WriteLine($"2.{employee2.employeeName} ");
                    Console.WriteLine($"3.{employee3.employeeName}");
                    Console.WriteLine($"4. Повысить всем");
                    Console.WriteLine("5. Вернуться назад");
                    Console.WriteLine("Выберите действие: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        Console.WriteLine("Напишите на сколько повысить");
                        int povishenieZp = Convert.ToInt32(Console.ReadLine());
                        employee1.salary = employee1.salary + povishenieZp;
                        Console.WriteLine($"Зарплата {employee1.employeeName} повышена на {povishenieZp} ");
                    }
                    if (cho == 2)
                    {
                        Console.WriteLine("Напишите на сколько повысить");
                        int povishenieZp = Convert.ToInt32(Console.ReadLine());
                        employee2.salary = employee2.salary + povishenieZp;
                        Console.WriteLine($"Зарплата {employee2.employeeName} повышена на {povishenieZp} ");
                    }
                    if (cho == 3)
                    {
                        Console.WriteLine("Напишите на сколько повысить");
                        int povishenieZp = Convert.ToInt32(Console.ReadLine());
                        employee3.salary = employee3.salary + povishenieZp;
                        Console.WriteLine($"Зарплата {employee3.employeeName} повышена на {povishenieZp} ");
                    }
                    if (cho == 4)
                    {
                        Console.WriteLine("Напишите на сколько повысить");
                        int povishenieZp = Convert.ToInt32(Console.ReadLine());
                        employee1.salary = employee1.salary + povishenieZp;
                        employee2.salary = employee2.salary + povishenieZp;
                        employee3.salary = employee3.salary + povishenieZp;
                        Console.WriteLine($"Зарплата всех повышена на {povishenieZp} ");
                    }
                }

            }

            if (ch == 3)
            {
                int cho = 0;
                while (cho != 5)
                {
                    Console.WriteLine("Выберите кому понизить зарплату");
                    Console.WriteLine($"1.{employee1.employeeName}");
                    Console.WriteLine($"2.{employee2.employeeName} ");
                    Console.WriteLine($"3.{employee3.employeeName}");
                    Console.WriteLine($"4. Понизить всем");
                    Console.WriteLine("5. Вернуться назад");
                    Console.WriteLine("Выберите действие: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        Console.WriteLine("Напишите на сколько понизить");
                        int ponizhenieZp = Convert.ToInt32(Console.ReadLine());
                        employee1.salary = employee1.salary - ponizhenieZp;
                        Console.WriteLine($"Зарплата {employee1.employeeName} понижена на {ponizhenieZp} ");
                    }
                    if (cho == 2)
                    {
                        Console.WriteLine("Напишите на сколько понизить");
                        int ponizhenieZp = Convert.ToInt32(Console.ReadLine());
                        employee2.salary = employee2.salary - ponizhenieZp;
                        Console.WriteLine($"Зарплата {employee2.employeeName} понижена на {ponizhenieZp} ");
                    }
                    if (cho == 3)
                    {
                        int ponizhenieZp = Convert.ToInt32(Console.ReadLine());
                        employee3.salary = employee3.salary - ponizhenieZp;
                        Console.WriteLine($"Зарплата {employee3.employeeName} понижена на {ponizhenieZp} ");
                    }
                    if (cho == 4)
                    {
                        Console.WriteLine("Напишите на сколько понизить");
                        int ponizhenieZp = Convert.ToInt32(Console.ReadLine());
                        employee1.salary = employee1.salary + ponizhenieZp;
                        employee2.salary = employee2.salary + ponizhenieZp;
                        employee3.salary = employee3.salary + ponizhenieZp;
                        Console.WriteLine($"Зарплата всех понижена на {ponizhenieZp} ");
                    }
                }

            }
            if (ch == 4)
            {

                
                int cho = 0;
                while (cho != 4)
                {
                    Console.WriteLine("Выберите какому сотруднику изменить должность");
                    Console.WriteLine($"1.{employee1.employeeName}");
                    Console.WriteLine($"2.{employee2.employeeName} ");
                    Console.WriteLine($"3.{employee3.employeeName}");
                    Console.WriteLine("4. Вернуться назад");
                    Console.WriteLine("Выберите действие: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        Console.WriteLine("Напишите на какую должность изменить");
                        string jobTitle = Console.ReadLine();
                        employee1.employeJobTitle = jobTitle;
                        Console.WriteLine($"Должность {employee1.employeeName} измененна на {jobTitle} ");
                    }
                    if (cho == 2)
                    {
                        Console.WriteLine("Напишите на какую должность изменить");
                        string jobTitle = Console.ReadLine();
                        employee1.employeJobTitle = jobTitle;
                        Console.WriteLine($"Должность {employee2.employeeName} измененна на {jobTitle} ");
                    }
                    if (cho == 3)
                    {
                        Console.WriteLine("Напишите на какую должность изменить");
                        string jobTitle = Console.ReadLine();
                        employee1.employeJobTitle = jobTitle;
                        Console.WriteLine($"Должность {employee3.employeeName} измененна на {jobTitle} ");
                    }
                   
                }
            }

            if (ch == 5)
            {
                Console.WriteLine($"Выход");
            }
            else {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}