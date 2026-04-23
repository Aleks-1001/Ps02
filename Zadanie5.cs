using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Регистрация пользователя");
        var userData = GetUserData();
        PrintUserData(userData);
        Console.ReadKey();
    }

    // 1. Метод, возвращающий кортеж с данными
    static (string firstName, string lastName, int age, bool hasPet, string[] petNames, string[] favoriteColors) GetUserData()
    {
        string firstName = GetValidString("Введите имя: ");
        string lastName = GetValidString("Введите фамилию: ");
        int age = GetPositiveInt("Введите возраст: ");

        // Наличие питомца
        Console.Write("Есть ли у вас питомцы? (да/нет): ");
        string petAnswer = Console.ReadLine().ToLower();
        while (petAnswer != "да" && petAnswer != "нет")
        {
            Console.Write("Некорректный ввод. Введите 'да' или 'нет': ");
            petAnswer = Console.ReadLine().ToLower();
        }

        bool hasPet = (petAnswer == "да");
        string[] petNames = new string[0];

        if (hasPet)
        {
            int petCount = GetPositiveInt("Сколько у вас питомцев? ");
            petNames = GetPetNames(petCount);
        }

        int colorCount = GetPositiveInt("Сколько у вас любимых цветов? ");
        string[] favoriteColors = GetColorNames(colorCount);

        return (firstName, lastName, age, hasPet, petNames, favoriteColors);
    }

    // Метод для ввода кличек питомцев
    static string[] GetPetNames(int count)
    {
        string[] names = new string[count];
        for (int i = 0; i < count; i++)
        {
            names[i] = GetValidString($"Введите кличку питомца {i + 1}: ");
        }
        return names;
    }

    // Метод для ввода любимых цветов
    static string[] GetColorNames(int count)
    {
        string[] colors = new string[count];
        for (int i = 0; i < count; i++)
        {
            colors[i] = GetValidString($"Введите любимый цвет {i + 1}: ");
        }
        return colors;
    }

    // Методы проверки ввода 
    static int GetPositiveInt(string prompt)
    {
        int number;
        bool isValid;
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out number) && number > 0;
            if (!isValid)
                Console.WriteLine("Ошибка! Введите целое положительное число.");
        } while (!isValid);
        return number;
    }

    static string GetValidString(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(input))
                Console.WriteLine("Ошибка! Строка не может быть пустой.");
            else if (IsAllDigits(input))
                Console.WriteLine("Ошибка! Имя не должно состоять только из цифр.");
            else
                break;
        } while (true);
        return input;
    }

    static bool IsAllDigits(string s)
    {
        foreach (char c in s)
            if (!char.IsDigit(c)) return false;
        return true;
    }

    // 3. Метод для вывода данных
    static void PrintUserData((string firstName, string lastName, int age, bool hasPet, string[] petNames, string[] favoriteColors) user)
    {
        Console.WriteLine("\n--- Данные пользователя ---");
        Console.WriteLine($"Имя: {user.firstName}");
        Console.WriteLine($"Фамилия: {user.lastName}");
        Console.WriteLine($"Возраст: {user.age}");
        Console.WriteLine($"Наличие питомца: {(user.hasPet ? "Да" : "Нет")}");

        if (user.hasPet)
        {
            Console.WriteLine("Питомцы:");
            for (int i = 0; i < user.petNames.Length; i++)
                Console.WriteLine($"  {i + 1}. {user.petNames[i]}");
        }

        Console.WriteLine("Любимые цвета:");
        for (int i = 0; i < user.favoriteColors.Length; i++)
            Console.WriteLine($"  {i + 1}. {user.favoriteColors[i]}");
    }
}

