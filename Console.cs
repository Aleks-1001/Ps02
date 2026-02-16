using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading.Tasks.Dataflow;
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
       
       /*
       Console.WriteLine("Введите свое имя");

       var name = Console.ReadLine();
       Console.WriteLine("Ваше имя по буквам:");
       int i;
       for ( i = name.Length -1 ; i >= 0; i--)
        {
         Console.Write(name[i] + "  ");   
        }
        */

         //int[,] array = { { 1,2,3 }, { 5,6,7 }};

//Console.Write("Количество строк: ");
//Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

//Console.Write("Количество колонок: ");
//Console.WriteLine(array.GetUpperBound(1) + 1 + " ");
    
    /*var arr = new int[] { 5, 6, 9, 1, 2, 3, 4};

   for (var i=0; i < arr.Length; i++)
        {
            Array.Sort(arr);
            Console.Write(arr[i]);
        }
        */

        /*
   var arr = new int[] { 5, -6, 9, 1, -2, -3, 4};
   // var sum = arr.Sum();
  // Console.WriteLine($"сумма масива {sum}" );

     Console.WriteLine("Положительные числа:");
// перебор массива вывод положительного числа
     foreach (int num in arr)
        {
            if (num > 0)
            {
                Console.WriteLine(num + " ");
            }
        }
        // перебор с помощью цикла фор вывод положительного числа
       for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
        // данный цикл выводит число положительных чисел в массиве =4
        var numbers = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            numbers++;
        }
        Console.WriteLine(numbers);

 int [][] array = new int[3][]; 

   array[0] = new int [2] {1 ,2};
   array[1] = new int [3] {1 ,2 ,3};
   array[2] = new int [5] {1, 2, 3, 4, 5,};

    foreach (var num in array)
        {
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
        }
        */
//задание 4.3.16
//найти в двумерном массиве положительные числа

/*int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

//перебор и вывод всех положительных чисел

foreach (int num in arr)

        {
            if (num > 0)
            {
                Console.WriteLine(num + " ");
            }
        }
        
        //перебор через фор и вывод количества положительных чисел
        int temp = 0;

        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
             for (int j = 0; j <= arr.GetUpperBound(1); j++)
            if (arr[i, j] > 0)
            temp++; 
        }
        Console.Write(temp);
        */
/*
       int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

int temp;
for (int i=0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                {
                if (arr[i,j] > arr[i,k])
                    {
                        temp = arr[i, k];
                        arr[i,k] = arr[i,j];
                        arr [i,j] = temp;
                    }
                }
            }
        }
   // Вывод отсортированного массива
for (int i = 0; i <= arr.GetUpperBound(0); i++)
{
    for (int j = 0; j <= arr.GetUpperBound(1); j++)
    {
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine(); // переход на новую строку
}


var (name, age) = ("aleksei", 23);

Console.WriteLine("Ваше имя: {0}", name);
Console.WriteLine("Ваш возраст: {0}", age);



(string name, int age) anketa;

Console.Write("Введите имя:");
anketa.name = Console.ReadLine();

Console.Write("Введите возраст:");
anketa.age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше имя: {0}", anketa.name);
Console.WriteLine("Ваш возраст: {0}", anketa.age);
*/

(string Name, String Type, double Age, int NameCount) Pet;
Console.WriteLine("Как зовут вашего питомца:");
Pet.Name= Console.ReadLine();

Console.WriteLine("К какому виду он относиться?");
Pet.Type= Console.ReadLine();

Console.WriteLine("Сколько лет вашему питомцу?");
Pet.Age= double.Parse(Console.ReadLine());
Pet.NameCount= Pet.Name.Length;

Console.WriteLine(" Имя:{0}\n Тип питомца:{1}\n Возраст:{2}\n Длина имени:{3}\n", Pet.Name , Pet.Type ,Pet.Age, Pet.NameCount );
}
}
