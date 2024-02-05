/* generate random number betweeen 1 and 10, prompt user to guess the number, use a loop to give the user multiple chances to guess, provide feedback after each guess, indicating if guess is too high or 
low, when user guesses the correct number, display a congratulatory message and the number of attempts made */

//Problems that I am having: The loop doesn't end when I guess the number, sometimes, the number I am supposed to be guessing changes when I guess a new number

using System;
public class Program
{
public int guessNumber;
public void Main ()
{
	Random random = new Random();
	guessNumber = random.Next(10 + 1);
	do{
	Console.WriteLine("Please guess a number between 1 and 10:");
	string userInput = Console.ReadLine();
	int userGuess = Int32.Parse(userInput);
	Guessing (userGuess);
	}
while(true);
}
	
	public void Guessing (int userGuess) {
	if(guessNumber == userGuess){
	Console.WriteLine("Great Job! You guessed the number!");	
	} else if (guessNumber > userGuess) {
		Console.WriteLine("Not quite. This guess is too low. Please try again!");
	} else {
		Console.WriteLine("Not quite. This guess is too high. Please try again!");
	}
		
	}
}
