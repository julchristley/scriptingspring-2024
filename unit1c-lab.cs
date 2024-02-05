using System;

public class Program
{
	public void Main()
	{
		Console.WriteLine("Please enter a positive integer for the number of rows in the pyramid:");// outputs the question
		string userInput = Console.ReadLine(); // prompts user input, stores that input as userInput
		int number = Int32.Parse(userInput); // translates userInput to int, now called number
		runPyramid(number); // runs public void runPyramid with int number
	}
	public void runPyramid(int number) // creates new public void, number is the value used in the void
	{
		for(int i = 1; i <= number; i++) // sets i = 1 in initial loop, and sets how many times loop runs (userinput number), i++ means that for every loop executed, it adds 1 to the previous number, starting at one, ending at the userinput number 
		{
			for (int a = 1; a <= i; a++) // sets a = 1 in initial loop, makes it so rows repeat numbers according to their value
			{
				Console.Write(i); // writes loop on one line
			}
			Console.WriteLine(); // writes next loop on another line
		}
	}
}
