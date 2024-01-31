using System;
public class Program
{
	public void Main()
	{
		Console.WriteLine("What is the current temperature in celsius?");
		string userTemp = Console.ReadLine();
		int temperature = Int32.Parse(userTemp);
		CheckTemperature(temperature);
	}
	public void CheckTemperature(int temperature) {
		if(temperature >= 30) {
			Console.WriteLine("Heat stroke is serious. Make sure to drink water and stay inside.");
		} else if (temperature < 30) {
			Console.WriteLine("The weather must be nice! You must be enjoying it!");
	}

	}
}
