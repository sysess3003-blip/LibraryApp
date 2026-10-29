using LibraryApp;

var library = new Library();
library.AddBook(new Book { Id = 1, Title = "Мастер и Маргарита", Author = "М. Булгаков" });
library.AddBook(new Book { Id = 2, Title = "Капитанская дочка", Author = "А. Пушкин" });
library.AddBook(new Book { Id = 3, Title = "Война и мир", Author = "Л. Толстой" });

Console.WriteLine("Проверка работы библиотеки после исправления ошибок:");
Console.WriteLine("1. Несуществующая книга:");
library.BorrowBook(999);
Console.WriteLine("2. Первая и повторная выдача:");
library.BorrowBook(1);
library.BorrowBook(1);
Console.WriteLine("3. Возврат невыданной книги:");
library.ReturnBook(2);
Console.WriteLine("4. Корректный возврат:");
library.ReturnBook(1);
Console.WriteLine($"Доступность книги №1: {library.FindBook(1)?.IsAvailable}");
