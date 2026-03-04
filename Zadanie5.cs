using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading.Tasks.Dataflow;



class Program
{
    static void Main()
    {
        Console.WriteLine("Регистрация пользователя");
        var userData = GetUserData();
        PrintUserData(userData);
        Console.ReadKey();
    }

    // 1. Метод, возвращающий кортеж с данными пользователя
    static (string FirstName, string LastName, int Age, string[] PetNames, string[] FavoriteColors) GetUserData()
    {
        string firstName = GetValidatedInput(
            "Введите имя: ",
            input => IsValidName(input, out string result) ? (true, result) : (false, null)
        );

        string lastName = GetValidatedInput(
            "Введите фамилию: ",
            input => IsValidName(input, out string result) ? (true, result) : (false, null)
        );

        int age = GetValidatedInput(
            "Введите возраст: ",
            input => IsPositiveInt(input, out int result) ? (true, result) : (false, 0)
        );

        bool hasPets = GetValidatedInput(
            "Есть ли у вас питомцы? (Да/Нет): ",
            input => IsYesNo(input, out bool result) ? (true, result) : (false, false)
        );

        string[] petNames = Array.Empty<string>();
        if (hasPets)
        {
            int petCount = GetValidatedInput(
                "Сколько у вас питомцев? ",
                input => IsPositiveInt(input, out int result) ? (true, result) : (false, 0)
            );

            petNames = new string[petCount];
            for (int i = 0; i < petCount; i++)
            {
                petNames[i] = GetValidatedInput(
                    $"Введите кличку питомца {i + 1}: ",
                    input => IsValidName(input, out string result) ? (true, result) : (false, null)
                );
            }
        }

        int colorCount = GetValidatedInput(
            "Сколько у вас любимых цветов? ",
            input => IsPositiveInt(input, out int result) ? (true, result) : (false, 0)
        );

        string[] favoriteColors = new string[colorCount];
        for (int i = 0; i < colorCount; i++)
        {
            favoriteColors[i] = GetValidatedInput(
                $"Введите любимый цвет {i + 1}: ",
                input => IsValidName(input, out string result) ? (true, result) : (false, null)
            );
        }

        return (firstName, lastName, age, petNames, favoriteColors);
    }

    // 2. Универсальный метод проверки ввода
    static T GetValidatedInput<T>(string prompt, Func<string, (bool IsValid, T Value)> validator)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine()?.Trim() ?? "";
            var result = validator(input);
            if (result.IsValid)
                return result.Value;
            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
        }
    }

    // Вспомогательные методы проверки

    static bool IsValidName(string input, out string result)
    {
        result = input;
        if (string.IsNullOrWhiteSpace(input))
            return false;
        // Проверяем, не является ли строка числом
        if (double.TryParse(input, out _))
            return false;
        return true;
    }

    static bool IsPositiveInt(string input, out int result)
    {
        if (int.TryParse(input, out result) && result > 0)
            return true;
        result = 0;
        return false;
    }

    static bool IsYesNo(string input, out bool result)
    {
        string lower = input.ToLower();
        if (lower == "да" || lower == "yes" || lower == "lf")
        {
            result = true;
            return true;
        }
        if (lower == "нет" || lower == "no" || lower == "ytn")
        {
            result = false;
            return true;
        }
        result = false;
        return false;
    }

    // 3. Метод вывода данных
    static void PrintUserData((string FirstName, string LastName, int Age, string[] PetNames, string[] FavoriteColors) user)
    {
        Console.WriteLine("\n--- Данные пользователя ---");
        Console.WriteLine($"Имя: {user.FirstName}");
        Console.WriteLine($"Фамилия: {user.LastName}");
        Console.WriteLine($"Возраст: {user.Age}");

        if (user.PetNames.Length > 0)
        {
            Console.WriteLine("Питомцы: " + string.Join(", ", user.PetNames));
        }
        else
        {
            Console.WriteLine("Питомцев нет");
        }

        Console.WriteLine("Любимые цвета: " + string.Join(", ", user.FavoriteColors));
    }
}