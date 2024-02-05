using System;
public class Program
{
	public void Main()
	{
		Console.WriteLine("What are your favorite foods?"); // displays question
		string favFood1 = Console.ReadLine(); // user inputs first favorite food, logs it as favFood1
		string favFood2 = Console.ReadLine(); // user inputs 2nd favorite food, logs it as favFood2
		string favFood3 = Console.ReadLine(); // user inputs 3rd favorite food, logs it as favFood3
		
		string [] userFood = {favFood1, favFood2, favFood3}; // strings the 3 favFoods
		
		foreach(var food in userFood) { // creates foreach loop, used to loop through arrays
			Console.WriteLine("I love " + food + "!"); // writes I love (favFood)! 3 times with each different food
		}
	}
}
