using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading.Tasks.Dataflow;


using System;

class Food{}
class Fruit : Food{}
class Vegetable :Food{}
    class Aple :Food{}
    class Banana : Fruit{}
    class Pear : Fruit{}
    class Potato : Vegetable{}
    class Carrot :Vegetable{}


class Employee
{
    public string Name;
    public int Age;
    public int Salary;

}
class ProjectManager : Employee
{
    public string ProjectName;
}
class Developer : Employee
{
private string ProgrammingLanguage;
}
class User
{
    private int age;
    private string email;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    static bool IsAllDigits(string s)
    {
        foreach (char c in s)
        {
            if (!char.IsDigit(c))
                return false;
        }
        return true;
    }

    public static int GetPositiveInt(string prompt)
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

    public static string GetValidString(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ошибка! Строка не может быть пустой.");
            }
            else if (input.Length <= 3)
            {
                Console.WriteLine("Ошибка! Введите больше 3 символов.");
            }
            else if (IsAllDigits(input))
            {
                Console.WriteLine("Ошибка! Имя не должно состоять только из цифр.");
            }
            else
            {
                break;
            }
        } while (true);
        return input;
    }

    // Новый метод для проверки email
    public static string GetValidEmail(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ошибка! Email не может быть пустым.");
            }
            else if (input.Length < 3)
            {
                Console.WriteLine("Ошибка! Email должен содержать не менее 3 символов.");
            }
            else if (!input.Contains("@"))
            {
                Console.WriteLine("Ошибка! Email должен содержать символ '@'.");
            }
            else
            {
                break;
            }
        } while (true);
        return input;
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        string name = User.GetValidString("Введите имя (не менее 4 символов): ");
        int age = User.GetPositiveInt("Введите возраст: ");
        string email = User.GetValidEmail("Введите email (не менее 3 символов, должен содержать @): ");

        User user = new User();
        user.Age = age;
        user.Email = email;
    

        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Возраст: {user.Age}");
        Console.WriteLine($"Email: {user.Email}");
    }
}
