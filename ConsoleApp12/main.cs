class main  
{
    static void Main(string[] args)
    {

        car car1 = new car();
        car1.model = "Toyota Camry";
        car1.brand = "Toyota";
        car1.date = 2020;  
        car1.dayPrice = 50;
        car1.daysRent = 0;

        car car2 = new car();
        car2.model = "Honda Accord";
        car2.brand = "Honda";
        car2.date = 2021; 
        car2.dayPrice = 55;
        car2.daysRent = 0;

        car car3 = new car();
        car3.model = "Ford Mustang";
        car3.brand = "Ford";
        car3.date = 2022; 
        car3.dayPrice = 70;  
        car3.daysRent = 0;


        int ch = 0;
        while (ch != 5)
        {

            Console.WriteLine("����:");
            Console.WriteLine("1. ������� �������� �����: ");
            Console.WriteLine("2. ������� ��� ������ ��������� ������");
            Console.WriteLine("3. ����� � ������");
            Console.WriteLine("4. ��������� ����");
            Console.WriteLine("5. �����");
            Console.WriteLine("�������� ��������: ");

            ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine($"1.{car1.model} " +
                    $"\n2.{car2.model}" +
                    $"\n3.{car3.model}");
            }

            if (ch == 2)
            {
                int cho = 0;
                while (cho != 4)
                {
                    Console.WriteLine("����:");
                    Console.WriteLine($"1.{car1.model}");
                    Console.WriteLine($"2.{car2.model} ");
                    Console.WriteLine($"3.{car3.model}");
                    Console.WriteLine("4. ��������� �����");
                    Console.WriteLine("�������� ��������: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        Console.WriteLine($"������: {car1.model} \n�����: {car1.brand} \n��� ������: {car1.date} \n���� �� 1 ����: {car1.dayPrice}");
                    }
                    if (cho == 2)
                    {
                        Console.WriteLine($"������: {car2.model} \n�����: {car2.brand} \n��� ������: {car2.date} \n���� �� 1 ����: {car2.dayPrice}");
                    }
                    if (cho == 3)
                    {
                        Console.WriteLine($"������: {car3.model} \n�����: {car3.brand} \n��� ������: {car3.date} \n���� �� 1 ����: {car3.dayPrice}");
                    }
                    if (cho == 4)
                    {
                        Console.WriteLine("������������ � ������� ����...");
                    }
                }

            }

            if (ch == 3)
            {
                int cho = 0;
                while (cho != 4)
                {
                    Console.WriteLine("���� ��� ������:");
                    Console.WriteLine($"1. {car1.model}");
                    Console.WriteLine($"2. {car2.model}");
                    Console.WriteLine($"3. {car3.model}");
                    Console.WriteLine("4. ��������� �����");
                    Console.WriteLine("�������� ��������: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        Console.WriteLine("�� ������� ����");
                           car1.daysRent = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{car1.model} ����� � ������ �� {car1.daysRent} ����.");
                    }
                    if (cho == 2)
                    {
                        Console.WriteLine("�� ������� ����");
                           car2.daysRent = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{car2.model} ����� � ������ �� {car2.daysRent} ����.");
                    }
                    if (cho == 3)
                    {
                        Console.WriteLine("�� ������� ����");
                           car3.daysRent = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{car2.model} ����� � ������ �� {car3.daysRent} ����.");
                    }
                    else if (cho == 4)
                    {
                        Console.WriteLine("������������ � ������� ����...");
                    }
                }

            }

            if (ch == 4)
            {
                int total = (car1.daysRent * car1.dayPrice) +
                   (car2.daysRent * car2.dayPrice) +
                   (car3.daysRent * car3.dayPrice);

                Console.WriteLine("��� ����:");
                if (car1.daysRent > 0)
                    Console.WriteLine($"{car1.model}: {car1.daysRent} x {car1.dayPrice} = {car1.daysRent * car1.dayPrice} c.");
                if (car2.daysRent > 0)
                    Console.WriteLine($"{car2.model}: {car2.daysRent} x {car2.dayPrice} = {car2.daysRent * car2.dayPrice} c.");
                if (car3.daysRent > 0)
                    Console.WriteLine($"{car3.model}: {car3.daysRent} x {car3.dayPrice} = {car3.daysRent * car3.dayPrice} c.");

                Console.WriteLine($"����� �����: {total} c.");
            }

            if (ch == 5)
            {
                Console.WriteLine($"�����");
            }
        }
    }
}