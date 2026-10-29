namespace LibraryApp;

/// <summary>Каталог книг и операции выдачи и возврата.</summary>
public sealed class Library
{
    private readonly List<Book> books = new();

    /// <summary>Добавляет книгу в каталог.</summary>
    /// <param name="book">Добавляемая книга.</param>
    /// <exception cref="ArgumentNullException">Книга не передана.</exception>
    /// <exception cref="InvalidOperationException">Книга с тем же Id уже существует.</exception>
    public void AddBook(Book book)
    {
        ArgumentNullException.ThrowIfNull(book);
        if (FindBook(book.Id) is not null)
            throw new InvalidOperationException("Книга с таким Id уже существует.");
        books.Add(book);
    }

    /// <summary>Ищет книгу по идентификатору; возвращает null, если её нет.</summary>
    /// <param name="id">Идентификатор.</param>
    /// <returns>Найденная книга либо null.</returns>
    public Book? FindBook(int id) => books.Find(book => book.Id == id);

    /// <summary>Пытается выдать доступную книгу.</summary>
    /// <param name="id">Идентификатор книги.</param>
    /// <returns>True, если выдача прошла успешно.</returns>
    public bool BorrowBook(int id)
    {
        Book? book = FindBook(id);
        if (book is null)
        {
            Console.WriteLine("Ошибка: книга не найдена.");
            return false;
        }
        if (!book.IsAvailable)
        {
            Console.WriteLine("Ошибка: книга уже выдана.");
            return false;
        }
        book.IsAvailable = false;
        Console.WriteLine($"Книга «{book.Title}» выдана.");
        return true;
    }

    /// <summary>Пытается вернуть ранее выданную книгу.</summary>
    /// <param name="id">Идентификатор книги.</param>
    /// <returns>True, если возврат прошёл успешно.</returns>
    public bool ReturnBook(int id)
    {
        Book? book = FindBook(id);
        if (book is null)
        {
            Console.WriteLine("Ошибка: книга не найдена.");
            return false;
        }
        if (book.IsAvailable)
        {
            Console.WriteLine("Ошибка: книга не была выдана.");
            return false;
        }
        book.IsAvailable = true;
        Console.WriteLine($"Книга «{book.Title}» возвращена.");
        return true;
    }
}
