class main : Book
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.bookName = "1984";
        book1.author = "������ ������";
        book1.bookStatus = true;

        Book book2 = new Book();
        book2.bookName = "������ � ���������";
        book2.author = "������ ��������";
        book2.bookStatus = true;

        Book book3 = new Book();
        book3.bookName = "����� ������������";
        book3.author = "������ ��";
        book3.bookStatus = true;

         public override void takeBook()
         {
        Console.WriteLine("�� ����� �����");
         }
         public abstract void returnBook()
         {
        Console.WriteLine("�� ������� �����");
         }

        int ch = 0;
        while (ch != 5)
        {

            Console.WriteLine("����:");
            Console.WriteLine("1. ������� ������ ���� ");
            Console.WriteLine("2. ����� �����");
            Console.WriteLine("3. ������� �����");
            Console.WriteLine("4. ������ ����");
            Console.WriteLine("5. �����");
            Console.WriteLine("�������� ��������: ");

            ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine($"1.{book1.bookName}, {book1.author} " +
                    $"\n2.{book2.bookName}, {book2.author} " +
                    $"\n3.{book3.bookName}, {book3.author}");
            }

            if (ch == 2)
            {
                int cho = 0;
                while (cho != 4)
                {
                    Console.WriteLine("���� ����:");
                    Console.WriteLine($"1.{book1.bookName}");
                    Console.WriteLine($"2.{book2.bookName} ");
                    Console.WriteLine($"3.{book3.bookName}");
                    Console.WriteLine("4. ��������� �����");
                    Console.WriteLine("�������� ��������: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        book1.bookStatus = false;
                        Console.WriteLine(book1.takeBook);
                    }
                    if (cho == 2)
                    {
                        book2.bookStatus = false;
                        Console.WriteLine(book2.takeBook);
                    }
                    if (cho == 3)
                    {
                        book3.bookStatus = false;
                        Console.WriteLine(book3.takeBook);
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
                    Console.WriteLine("���� ��� �������� ����:");
                    Console.WriteLine($"1.{book1.bookName}");
                    Console.WriteLine($"2.{book2.bookName} ");
                    Console.WriteLine($"3.{book3.bookName}");
                    Console.WriteLine("4. ��������� �����");
                    Console.WriteLine("�������� ��������: ");

                    cho = Convert.ToInt32(Console.ReadLine());

                    if (cho == 1)
                    {
                        book1.bookStatus = true;
                        Console.WriteLine(book1.returnBook);
                    }
                    if (cho == 2)
                    {
                        book2.bookStatus = true;
                        Console.WriteLine(book2.returnBook);
                    }
                    if (cho == 3)
                    {
                        book3.bookStatus = true;
                        Console.WriteLine(book3.returnBook);
                    }
                    else if (cho == 4)
                    {
                        Console.WriteLine("������������ � ������� ����...");
                    }
                }

            }
            if (ch == 4)
            {
                Console.WriteLine("������ ����:");
                Console.WriteLine($"{book1.bookName}: {(book1.bookStatus ? "��������" : "�����")}" +
                                  $"\n{book2.bookName}: {(book2.bookStatus ? "��������" : "�����")}" +
                                  $"\n{book3.bookName}: {(book3.bookStatus ? "��������" : "�����")}");
            }

            if (ch == 5)
            {
                Console.WriteLine($"�����");
            }
        }
    }
}