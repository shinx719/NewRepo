class Student{ 
    public string Name { get; set; }
    public int Number { get; set; } // Номер студента
    public string ArrivalTime { get; set; } // Время прихода

    public Student(string name, int number)
    {
        Name = name;
        Number = number;
}
}
class Program{
static void Main(){
    List<Student> students = new List<Student>   {
            new Student("Носимжон", 1),
            new Student("Адис", 2),
            new Student("Эрбол", 3),
            new Student("Бекмураз", 4),
            new Student("Ислам", 5),
            new Student("Арсен", 6),
            new Student("Адинай", 7),
            new Student("Сергей", 8),
            new Student("Байэл", 9),
            new Student("Абдурахман", 10),
            new Student("Аймээрим", 11),
            new Student("Эрлан", 12),
            new Student("Эрзат", 13),
            new Student("Калмурат", 14),
            new Student("Даниял", 15),
            new Student("Абдынур", 16),
            new Student("Атай", 17),
            new Student("Акылбек", 18),
            new Student("Элдос", 19),
            new Student("Рысбек", 20),
            new Student("Азим", 21),
            new Student("Адинай Шай", 22),
            new Student("Тазагул", 23),
            new Student("Милана", 24)
    };
    HashSet<int> selecNumbr = new HashSet<int>();
    Random random = new Random();
    while (selecNumbr.Count < 12){
        selecNumbr.Add(random.Next(1, 25));
    }
    foreach (var number in selecNumbr){
        students[number - 1].ArrivalTime = "10:00";
    }
     foreach (var student in students){
        if (student.ArrivalTime == null){
        student.ArrivalTime = "13:00";
    }
     }
     Console.WriteLine("Список студентов и их время прихода:");
        foreach (var student in students)
        {
            Console.WriteLine($"№{student.Number}: {student.Name}, Время прихода: {student.ArrivalTime}");
        }

        int ch = 0;
            while (ch != 3) {

                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввести имя");
                Console.WriteLine("2. Вывести всех");
                Console.WriteLine("3. Выход");
                Console.WriteLine("Выберите действие: ");

                ch = Convert.ToInt32(Console.ReadLine());
        if (ch == 1)  {      
        Console.WriteLine("\nВведите ваше имя для проверки времени прихода:");
        string inputName = Console.ReadLine();

        string arrivalTime = CheckStudentArrivalTime(inputName, students);

        if (arrivalTime != null)
        {
            Console.WriteLine($"Вы приходите в {arrivalTime}.");
        }
        }
         else if (ch == 2)
            {
               Console.WriteLine("Список всех студентов:");
                foreach (var student in students)
                {
                    Console.WriteLine($"№{student.Number}: {student.Name}, Время прихода: {student.ArrivalTime}");
                }
            }
             else if (ch == 3)
            {
                Console.WriteLine("Выход");
            }
        }
        static string CheckStudentArrivalTime(string name, List<Student> students)
         {
       
        foreach (var student in students)
        {
            if (student.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return student.ArrivalTime; 
            }
        }
        return null;
        
}
}
}

