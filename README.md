# LibraryApp: практическая подготовка 4–6

C# / .NET 8, Visual Studio 2022. Программа демонстрирует учёт книг и поиск дефектов через отладку.

## Состав решения
- `LibraryApp` — исправленное консольное приложение: классы `Book`, `Library`, `Program`.
- `LibraryApp.Buggy` — исходная версия с **тремя преднамеренными дефектами**, нужна для скриншотов «до» и анализа кода.
- `TEST_REPORT.md` — описание сценариев и найденных дефектов.
- `Screenshots/` — место для собственных скриншотов.

## Запуск
1. Открыть `LibraryApp.sln` в Visual Studio 2022 с .NET 8 SDK.
2. Правый щелчок по `LibraryApp` → «Назначить запускаемым проектом» → F5 или Ctrl+F5.
3. Для отладки исходной версии назначить запускаемым `LibraryApp.Buggy`.
4. В свойствах `LibraryApp.Buggy` → «Отладка» → «Аргументы командной строки» указывать по очереди `missing`, `repeat`, `return` (для `missing` аргумент можно оставить пустым).
5. Поставить F9 на строках `Book book = FindBook(id);`, `book.IsAvailable = ...` и внутри `FindBook`. Запустить F5, затем F10/F11 и смотреть окна «Локальные»/«Контрольные значения».
6. Снимки делать на неисправленной и исправленной версиях. Сравнить сообщения и состояние `IsAvailable`.

## Запуск из терминала
```powershell
dotnet run --project LibraryApp
dotnet run --project LibraryApp.Buggy -- missing
dotnet run --project LibraryApp.Buggy -- repeat
dotnet run --project LibraryApp.Buggy -- return
```

## Инспекция и Git
В Visual Studio: «Анализ → Выполнить анализ кода» (если доступно), «Вид → Список ошибок». Сравнить исходную и исправленную версии. Включить «Git → Создать репозиторий», опубликовать на GitHub с `README.md` и `TEST_REPORT.md`. `.gitignore` уже включён. НЕ удалять проект `.Buggy`: это доказательство исходных дефектов.
