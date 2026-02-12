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
     /*
  Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your age: ");
byte age = (byte)int.Parse(Console.ReadLine());


Console.WriteLine("Your name is {0} and age is {1} ", name, age );
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
var myapples = 5;
var hisapples = 6;
var hispeares = 5;

var result = (myapples != hispeares) & (myapples < hisapples); // логические операции

Console.WriteLine(result); // вывод после логической операции

int currenDayInyear = 293;
bool isLeapYear = false;

bool isWinter=
!isLeapYear & ( currenDayInyear >= 335 | currenDayInyear <= 59)
|
isLeapYear & ( currenDayInyear >= 336 | currenDayInyear <= 60);

ConsoleWriteLine("Current season is winter {0}" , isWinter);

// задание 4.1.4 
string a;
string b;

bool c= a != b; // Забыл восклицательный знак

// задание 4.1.5
int A;
int B;
double X;
double Y;

bool C=
(A < B) | (X > Y); // не поставил скобки
*/

// Задание 4.1.17 работа с цветом
/*
int t = 0;
do 
{
    Console.WriteLine(t);

Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

		switch (Console.ReadLine()) {
case "red":
  Console.BackgroundColor = ConsoleColor.Red;
  Console.ForegroundColor = ConsoleColor.Black;

  Console.WriteLine("Your color is red!");
  break;

case "green":
  Console.BackgroundColor = ConsoleColor.Green;
  Console.ForegroundColor = ConsoleColor.Black;

  Console.WriteLine("Your color is green!");
  break;
case "cyan":
  Console.BackgroundColor = ConsoleColor.Cyan;
  Console.ForegroundColor = ConsoleColor.Black;

  Console.WriteLine("Your color is cyan!");
  break;
default:
  Console.BackgroundColor = ConsoleColor.Yellow;
  Console.ForegroundColor = ConsoleColor.Red;

  Console.WriteLine("Your color is yellow!");
  break;
}
t++;
}while (t < 3);*/

/*
int k = 0;

while (true) 
{
  Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
  Console.WriteLine(k);

  var text = Console.ReadLine();

  if (text == "stop") 
  {
    Console.WriteLine("Цикл остановлен");
    break;
  }


 k++;
    }
*/
/*
    int sum = 0;

      while (true)       {
        Console.WriteLine("Введите число");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)        
         {
          continue;
        }

        else if (number == 0)        
         {
          break;
        }

        // number > 0
        sum += number;
      }

      Console.WriteLine("Итоговая сумма: {0}", sum);
      
     string[] favcolors = new string[3];

     for(int i = 0; i  < favcolors.Length; i ++)
        {
            Console.WriteLine(" Введите номер цвета {0}", i +1);
            favcolors[i]=Console.ReadLine();
        }
        foreach(var color in favcolors)
        {
            //switch (color)
        }
        */
       Console.WriteLine("Введите свое имя");

       var name = Console.ReadLine();
       Console.WriteLine("Ваше имя по буквам:");
       
       foreach(var ch in name)
        {
         Console.Write(ch + "  ");   
        }
        Console.WriteLine("Последняя буква вашего имени:  {0}", name[0]);

    }
}
