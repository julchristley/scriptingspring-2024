using System;
					
public class Program
{
	public static void Main()
	{
		int num1 = 12; //declaring and initializing num1
		Console.WriteLine(num1); //this will display value of num1 (12)
		
		float num2 = 7.77f; // declaring and initializng num2, f on the end of the number is because it is a float
		Console.WriteLine(num2); // this will display value of num2 (7.77)
		
		bool areSunsetsPretty = true; // declaring and initializing the boolean areSunsetsPretty
		Console.WriteLine(areSunsetsPretty);// this will display the value of areSunsetsPretty(true)
		
		string color = "orange"; // declaring and initializing string color
		string flower = "marigold"; // declaring and initializing string flower
		Console.WriteLine("the " + flower + "s" + " are " + color + "!"); // this will display "the marigolds are orange!"
		
		int x = 30, y = 3; // declaring and initializing variable x and y
		Console.WriteLine(x+y); // this will display the sum of x+y (30+3)
		
		Console.WriteLine(x-y); //this will display the difference of x-y (30-3)
		
		Console.WriteLine(x*y); // this will display the product of x*y (30*3)
		
		Console.WriteLine(x/y); // this will display the quotient of x/y (30/3)
		
		Console.WriteLine("What is your favorite animal?"); // will display "What is your favorite animal?"
		string favoriteAnimal = Console.ReadLine(); // Console.Readline will prompt user input, string favoriteAnimal will save the user input as a string variable
		Console.WriteLine("Favorite animal is: " + favoriteAnimal); // will display "favorite animal is:" and userinput
	}
}
