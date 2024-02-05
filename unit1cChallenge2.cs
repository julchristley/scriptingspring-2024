using System;
public class Program
{
	public void Main()
	{
		Console.WriteLine("What are your favorite foods?");
		string favFood1 = Console.ReadLine();
		string favFood2 = Console.ReadLine();
		string favFood3 = Console.ReadLine();
		
		string [] userFood = {favFood1, favFood2, favFood3};
		
		foreach(var food in userFood) {
			Console.WriteLine("I love " + food + "!");
		}
	}
}
