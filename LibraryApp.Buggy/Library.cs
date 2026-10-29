namespace LibraryApp.Buggy;

// НАМЕРЕННО НЕИСПРАВЛЕННЫЙ КОД ТОЛЬКО ДЛЯ ОТЛАДКИ.
public class Library
{
    private List<Book> books = new();

    public void AddBook(Book book) { books.Add(book); }

    public Book FindBook(int id) { return books.Find(book => book.Id == id); }

    public void BorrowBook(int id)
    {
        string? testBook = null;
        Console.WriteLine(testBook.Length);
        Book book = FindBook(id);
        book.IsAvailable = false; // ДЕФЕКТ 1: NullReferenceException при отсутствующем Id.
                                  // ДЕФЕКТ 2: нет проверки повторной выдачи.
        Console.WriteLine("Выдана книга: " + book.Title);
    }

    public void ReturnBook(int id)
    {
        Book book = FindBook(id);
        book.IsAvailable = true; // ДЕФЕКТ 3: разрешён возврат невыданной книги.
        Console.WriteLine("Возвращена книга: " + book.Title);
    }
}
