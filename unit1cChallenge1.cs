/* generate random number betweeen 1 and 10, prompt user to guess the number, use a loop to give the user multiple chances to guess, provide feedback after each guess, indicating if guess is too high or 
low, when user guesses the correct number, display a congratulatory message and the number of attempts made */

// displays "great job!" line and "try again" line alot, doesn't loop, no idea about the number of attempts thing

using System;
public class Program
{
public int guessNumber;
public void Main ()
{
	Random random = new Random();
	guessNumber = random.Next(1,11);
	Console.WriteLine("Please guess a number between 1 and 10:");
	string userInput = Console.ReadLine();
	int userGuess = Int32.Parse(userInput);
	guessingCorrect (userGuess);
	guessingIncorrect (userGuess);
}
	public void guessingCorrect (int userGuess) {
	for (int i = userGuess; i <= 10 ; i = i+0) {
		if (i == guessNumber)
		{
			break;
		}
		Console.WriteLine("Great job! You guessed the number!");
	}
	}
	public void guessingIncorrect (int userGuess) {
	for (int i = userGuess; i <= 10; i= i+0) {
		if (i != guessNumber)
		{ break; }
		
		Console.WriteLine("try again");
}
	}
}
	
	
	/*} else if (guessNumber > userGuess){
		Console.WriteLine("Not quite, this guess is too low. Please try again!");
	} else {
		Console.WriteLine("not quite, this guess is too high. Please try again!");
	}
	}
}*/
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
