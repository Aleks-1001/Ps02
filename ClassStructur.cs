using System;



namespace Ps02;

//public class ClassStructur
//{
    class Pen
    {
        public string color;
        public int cost;
    
public void Greetings()
		{
			Console.WriteLine("Цвет {0}, Число{1}", color, cost);
		}
        public Pen()
        {
            
            color = "Черный";
            cost = 100;
        }
        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }
class Program {
	static void Main(string[] args)       
      {
		Pen pen = new Pen();
		pen.Greetings();

        pen = new Pen("Черный", 100);
        pen.Greetings();
		
		Console.ReadKey();
	}
}