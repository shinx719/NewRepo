class main
{
    static void Main(string[] args)
    {

        Order order1 = new Order();
        order1.orderName = "���";
        order1.orderCount = 0;
        order1.orderPrice = 100;

        Order order2 = new Order();
        order2.orderName = "���";
        order2.orderCount = 0;
        order2.orderPrice = 200;

        Order order3 = new Order();
        order3.orderName = "����� ";
        order3.orderCount = 0;
        order3.orderPrice = 500;


        int ch = 0;
        while (ch != 5)
        {

            Console.WriteLine("����:");
            Console.WriteLine("1. ������� ��� ����: ");
            Console.WriteLine("2. ������� �����");
            Console.WriteLine("3. ��������� �����");
            Console.WriteLine("4. ��������� ����");
            Console.WriteLine("5. �����");
            Console.WriteLine("�������� ��������: ");

            ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine($"1.{order1.orderName} ���� {order1.orderPrice} c." +
                    $"\n2.{order2.orderName} ���� {order2.orderPrice} c." +
                    $"\n3.{order3.orderName}���� {order3.orderPrice} c.");
            }

            if (ch == 2)
            {
                int cho = 0;
                while (cho != 4)
                {
                    Console.WriteLine("����:");
                    Console.WriteLine("1. ������ ����");
                    Console.WriteLine("2. ������� ���");
                    Console.WriteLine("3. �����");
                    Console.WriteLine("4. ��������� �����");
                    Console.WriteLine("�������� ��������: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        Console.WriteLine($"��� �����: {order1.orderName}");
                    }
                    if (cho == 2)
                    {
                        Console.WriteLine($"��� �����: {order2.orderName}");
                    }
                    if (cho == 3)
                    {
                        Console.WriteLine($"��� �����: {order3.orderName}");
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
                    Console.WriteLine("���� ��� ����������:");
                    Console.WriteLine("1. ������ ����");
                    Console.WriteLine("2. ������� ���");
                    Console.WriteLine("3. �����");
                    Console.WriteLine("4. ��������� �����");
                    Console.WriteLine("�������� ��������: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        order1.orderCount++;
                        Console.WriteLine($"��������� ������: {order1.orderName}");
                    }
                    if (cho == 2)
                    {
                        order2.orderCount++;
                        Console.WriteLine($"��������� ������: {order2.orderName}");
                    }
                    if (cho == 3)
                    {
                        order3.orderCount++;
                        Console.WriteLine($"��������� ������: {order3.orderName}");
                    }
                    else if (cho == 4)
                    {
                        Console.WriteLine("������������ � ������� ����...");
                    }
                }

            }

            if (ch == 4)
            {
                int total = (order1.orderCount * order1.orderPrice) +
                   (order2.orderCount * order2.orderPrice) +
                   (order3.orderCount * order3.orderPrice);

                Console.WriteLine("��� ����:");
                if (order1.orderCount > 0)
                    Console.WriteLine($"{order1.orderCount * order1.orderPrice} c.");
                if (order2.orderCount > 0)
                    Console.WriteLine($"{order2.orderCount * order2.orderPrice} c.");
                if (order3.orderCount > 0)
                    Console.WriteLine($"{order3.orderCount * order3.orderPrice} c.");

                Console.WriteLine($"����� �����: {total} c.");
            }

            if (ch == 5)
            {
                Console.WriteLine($"�����");
            }
        }
    }
}