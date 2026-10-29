using LibraryApp.Buggy;

var library = new Library();
library.AddBook(new Book { Id = 1, Title = "Мастер и Маргарита", Author = "М. Булгаков" });
library.AddBook(new Book { Id = 2, Title = "Капитанская дочка", Author = "А. Пушкин" });

string scenario = args.Length > 0 ? args[0] : "missing";
Console.WriteLine("Исходная версия. Сценарий: " + scenario);
switch (scenario)
{
    case "missing":
        library.BorrowBook(999); // Должно быть сообщение, но будет исключение.
        break;
    case "repeat":
        library.BorrowBook(1);
        library.BorrowBook(1); // Ошибочно выдаст повторно.
        break;
    case "return":
        library.ReturnBook(2); // Ошибочно вернёт доступную книгу.
        break;
    default:
        Console.WriteLine("Аргументы: missing, repeat, return");
        break;
}
