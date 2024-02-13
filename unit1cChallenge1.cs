using System;
public class Program
{
public int guessNumber; // makes it so all voids have access to the guessNumber
public int attempt = 0; // makes it so the attempt count starts at 0

	public void Main ()

	{
		generateNumber(); //runs generateNumber void
		questionAsk(); // runs questionAsk void
	}
			public void generateNumber() { // creates generateNumber void
			Random random = new Random(); // generates a random number
			guessNumber = random.Next(1,11); // sets the parameter for the number, which is 1 <= number > 11
		}
	
				public void guessingLoops (int guessNumber, int userGuess) { // creates guessingCorrect void
				for (int i = userGuess; i <= 10 ; i++) { // sets i equal to userGuess, i will be equal to or lower than 10, adds 1 every loop
				if (i == guessNumber) { // if userGuess is equal to guessNumber (randomly generated number),
				Console.WriteLine("Great job! You guessed the number!"); // displays the writing
				break; // stops the loop
		
				} else if (i > guessNumber) { // if userGuess is higher than the randomly generated number,
				Console.WriteLine("too high"); // displays writing
				questionAsk(); //runs questionAsk void
				break; //breaks loop
		
				}else if (i < guessNumber) { // if userguess is lower than randomly generated number,
				Console.WriteLine("too low"); // displays writing
				questionAsk(); //runs questionAsk void
				break; // breaks loop
			} 
		}
	
	}
		public void questionAsk() { // creates questionAsk void
		Console.WriteLine("Please guess a number between 1 and 10:"); // displays writing
		string userInput = Console.ReadLine(); // makes variable userInput whatever number the user inputs
		int userGuess = Int32.Parse(userInput); // converts user input from a string to and integer so the input can be used in comparing variables
		guessingLoops (guessNumber, userGuess); // runs guessingLoops void
		Console.WriteLine("Attempts made:" + attempt); // displays "Attempts made:" and however many attempts user made
	}
}
