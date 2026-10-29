namespace LibraryApp;

/// <summary>Книга с состоянием доступности для выдачи.</summary>
public sealed class Book
{
    /// <summary>Уникальный идентификатор книги.</summary>
    public int Id { get; set; }

    /// <summary>Название книги.</summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>Автор книги.</summary>
    public string Author { get; set; } = string.Empty;

    /// <summary>Можно ли выдать книгу читателю.</summary>
    public bool IsAvailable { get; set; } = true;
}
