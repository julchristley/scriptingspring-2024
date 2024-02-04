using System;

public class Program
{
	public void Main()
	{
		//string car = "mustang"; single variable, it is a car, the value is mustang
		string [] cars = {"mustang", "camaro", "hellcat", "corvet", "viper", "mccleran"} ; // square brackets show that it's an array, multiple variables
		Console.WriteLine(cars.Length); // output is 3
		Console.WriteLine(cars[0]); //mustang = 0, camaro = 1. hellcat = 2, output is mustang
		Console.WriteLine(cars[1]); // output camaro
		Console.WriteLine(cars[2]); // output hellcat
	
		foreach(var car in cars) {
			Console.WriteLine("I love my " + car + ".");
		}
		
	}
}

/*
using System;

public class Program
{
	public static void Main()
	{
		string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
		//playerTypes[1] = "Queen"; change 1 at a time
		
		for (var i = 0; i < playerTypes.Length; i++ ) { // i is an indexer, checks to see if it's less than the length, if it is, i++. will run this particular loop 3 times
			playerTypes[i] = "Queen"; // will only all 3 items
		}
		
		foreach(var playerType in playerTypes) {
		Console.WriteLine(playerType);
		}
	}
}
*/
