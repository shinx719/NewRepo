public abstract class Book()
{
    public String bookName { get; }
    public String author { get; }
    public bool bookStatus { get; }
    
    public abstract void takeBook()
    {
        Console.WriteLine("Вы взяли книгу");
    }
    public abstract void returnBook()
    {
        Console.WriteLine("Вы вернули книгу");
    }

}
