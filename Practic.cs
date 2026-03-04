using System.Reflection.Metadata;
using System.Runtime.Loader;

namespace Ps02;

public class Practic
{
  
static void Echo(string saidworld, int deep)
{
    var originalColor = Console.ForegroundColor;
    ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue,
                              ConsoleColor.Yellow, ConsoleColor.Cyan, ConsoleColor.Magenta };
    Console.ForegroundColor = colors[deep % colors.Length];

   Console.WriteLine("..." + saidworld);


    var modif = saidworld;
    if (modif.Length > 2)
        modif = modif.Remove(0, 2);

    if (deep > 1)
        Echo(modif, deep - 1);

   
    Console.ForegroundColor = originalColor; // восстановление
}
  
  /*
    static void SortArrayDesc(in int[] array, out int[] sorteddesc)
  {
    SortArrayAsc(array, out sorteddesc);
    Array.Reverse(sorteddesc);
    
  }

   static void SortArrayAsc(in int[] array, out int[] sortedasc)
  {
     sortedasc = new int[array.Length];
     Array.Copy(array, sortedasc, array.Length);

     Array.Sort(sortedasc);
  }
  static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
  {
    SortArrayAsc(array, out sortedasc);
        SortArrayDesc(array, out sorteddesc);
  }
*/
   /* static void Quest(string Name, int Age)
  {
    (string Name, int Age, string Login) User;

Console.WriteLine("Введите имя:");
User.Name = Console.ReadLine();

Console.WriteLine("Введите возраст:");
User.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите имя:");
User.Login = Console.ReadLine();


  }*/
    
private static int PowerUp(int N, byte pow)
  {
    if (pow == 0)
    {
      return 1;
    }
    else{

      if (pow == 1)
      {
        return N;
      }
    
      else
      {
        return N *PowerUp(N,--pow);
      }
    }

  }

    static decimal Factorial(int x)
  {
    if (x == 0)
    {
      return 1;
    }
    else
    {
      return x * Factorial(x-1);
    }
  }
    static void Main(string[] args)
 {
Console.WriteLine (PowerUp(5, 3));
var x=20;

Console.WriteLine(Factorial(x));
  /*int[] original = { 5, 2, 8, 1, 9 };
        
        // Получаем отсортированные массивы
        SortArray(original, out int[] desc, out int[] asc);
        
        Console.WriteLine("Исходный массив: " + string.Join(", ", original));
        Console.WriteLine("По возрастанию:  " + string.Join(", ", asc));
        Console.WriteLine("По убыванию:     " + string.Join(", ", desc));
*/
       Console.WriteLine("Напешите чтонибудь");
       var str = Console.ReadLine();

       Console.WriteLine("Введите число повторений");
       var deep = int.Parse(Console.ReadLine());




      // for (int i= 0; i<deep; i++)
   // {
      Echo(str, deep);
       Console.ResetColor(); 
   // } 
     
    

    // Quest;

      /*   
(string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

for (int k = 0; k < 3; k++)
{
Console.WriteLine("Введите имя");
User.Name = Console.ReadLine();

 Console.WriteLine("Введите фамилию");
 User.LastName = Console.ReadLine();

  Console.WriteLine("Введите логин");
  User.Login = Console.ReadLine();
  User.LoginLength = User.Login.Length;

Console.WriteLine("Есть ли у вас животные? Да или Нет");

var result = Console.ReadLine();

if (result == "Да")
        {
            User.HasPet= true;
        }
else 
{
            User.HasPet= false;
        }

        Console.WriteLine("Введите возраст пользователя");
    User.Age= double.Parse(Console.ReadLine());




            User.favcolors = new string[3];

            Console.WriteLine("Введите три любимых цвета пользователя");


            for (int i = 0; i < User.favcolors.Length; i++)
            {  
               User.favcolors[i]= Console.ReadLine();
            }

        }
    }
*/


/*	static void ShowColor()
	{
		Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
    var color = Console.ReadLine();

    switch (color) {
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
	}

  public static void Main (string[] args) {
		
		var (name, age) = ("Евгения", 27);

		Console.WriteLine("Мое имя: {0}", name);
		Console.WriteLine("Мой возраст: {0}", age);

		Console.Write("Введите имя: ");
		name = Console.ReadLine();
		Console.Write("Введите возрас с цифрами:");
		age = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Ваше имя: {0}", name);
		Console.WriteLine("Ваш возраст: {0}", age);

		ShowColor();

	*/
  }
}

