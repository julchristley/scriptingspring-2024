/* generate random number betweeen 1 and 10, prompt user to guess the number, use a loop to give the user multiple chances to guess, provide feedback after each guess,
indicating if guess is too high or low, when user guesses the correct number, display a congratulatory message and the number of attempts made */



// Problems that I am having: It seems like the generated number changes every time the user adds a new input, and the user attempt number is wrong.

using System;
public class Program
{
public int guessNumber;
public int attempt = 0;
public void Main ()
{
	generateNumber();
	questionAsk();
}
	public void generateNumber() {
	Random random = new Random();
	guessNumber = random.Next(1,11);
	}
	
	public void guessingCorrect (int guessNumber, int userGuess) {
	for (int i = userGuess; i <= 10 ; i++) {
		if (i == guessNumber) {
		Console.WriteLine("Great job! You guessed the number!");
		break;
		
		} else if (i > guessNumber) {
		Console.WriteLine("too high");
		questionAsk();
		break;
		
	}else if (i < guessNumber) {
		Console.WriteLine("too low");
		questionAsk();
		break;
	} 
	}
	
	}
public void questionAsk() {
	Console.WriteLine("Please guess a number between 1 and 10:");
	string userInput = Console.ReadLine();
	int userGuess = Int32.Parse(userInput);
	guessingCorrect (guessNumber, userGuess);
	Console.WriteLine("Attempts made:" + attempt);
}
}
