using System;
class MainClass
{
    public static void Main (string[] args)
    {
      /*  string MyName;
        MyName = "Aleksei";
        Console.WriteLine(MyName);
  Console.Write("Enter your age: ");
     int age;   
     bool iscorrect = int.TryParse(Console.ReadLine(), out age);
     Console.WriteLine("Your age is {0} ", age);
     */
  Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your age: ");
byte age = (byte)int.Parse(Console.ReadLine());

Console.WriteLine("Your name is {0} and age is {1}", name, age);
Console.WriteLine("{0}, do you have a hobby?", name);
Console.WriteLine("1 - yes \n2 - no");

byte hobbyChoice = (byte)int.Parse(Console.ReadLine());

if (hobbyChoice == 1)
{
    Console.WriteLine("What is your hobby?");
    string hobby = Console.ReadLine();
    Console.WriteLine("Great! Your hobby is: " + hobby);
}
else if (hobbyChoice == 2)
{
    Console.WriteLine("It's a pity you don't have a hobby");
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.ReadKey();
    }
}