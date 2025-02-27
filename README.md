**ОРЛОВ ЯРОСЛАВ ИСД-33**
**ЗАДАНИЕ Разработать приложение, в котором**

**пользователь может:**
- Создавать и удалять категории
заметок
- Внутри категорий добавлять и
удалять заметки
это веб-приложение для управления заметками, организованными по категориям.

## Требования к среде разработки

Для запуска и разработки  необходимо установить следующие компоненты:

1. **.NET SDK**: Установи новейшую версию .NET SDK .
2. **IDE**: Рекомендуется использовать Visual Studio или Visual Studio Code.

## Установка необходимых компонентов

3. **Установи необходимые пакеты**:
  Открой терминал в корневом каталоге твоего проекта и выполни следующие команды для установки необходимых пакетов:

   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCore.Design
   dotnet add package Microsoft.EntityFrameworkCore.Tools
   dotnet add package Microsoft.EntityFrameworkCore.Sqlite

4. **Настройка подключения к базе данных SQLite**

   **Настрой строку подключения:**

Открой файл appsettings.json и обнови строку подключения в разделе ConnectionStrings:

Copy
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=noteapp.db"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

Эта строка подключения указывает на использование файла базы данных noteapp.db в текущем каталоге.

5. **Примените миграции:**

Выполни следующие команды для создания и применения миграций:


dotnet ef migrations add InitialCreate
dotnet ef database update
Инструкции по запуску приложения
Запусти приложение:

6. **В терминале выполни команду:**

dotnet run

7. **Открой приложение в браузере:**

Перейди по адресу https://localhost:5001 или http://localhost:5000 в твоем браузере.
