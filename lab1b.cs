using System;
public class Program
{
	public void Main()
	{
		Console.WriteLine("What is the current temperature in celsius?"); // will display temperature question
		string userTemp = Console.ReadLine(); // will prompt user input, will save that input as userTemp
		int temperature = Int32.Parse(userTemp); // changes the string variable userTemp to int variable temperature
		CheckTemperature(temperature); // runs public void CheckTemperature with variable temperature
	
	Console.WriteLine(" "); // this is to put a blank line in the output. There's a better way to do this, right?
		
		Console.WriteLine("What is your exam score as a percentage?"); // will display the exam score question
		string userScore = Console.ReadLine(); // will prompt user input, will save input as userScore
		int examScore = Int32.Parse(userScore); // changes the string variable userScore to int variable examScore
		GradeCheck(examScore); // runs public void examScore with the variable examScore
		
	}
	public void CheckTemperature(int temperature) { // the int temperature is the value that is used in this void
		if(temperature >= 30) { // compares the user's input (temperature) to check if it is greater than 30
			Console.WriteLine("Heat stroke is serious. Make sure to drink water and stay inside."); // displays text, if above requirement is met
		} else if (temperature < 30) { // if user's input does not meet the first if statement's requirement, checks if it is less than 30
			Console.WriteLine("The weather must be nice! You must be enjoying it!"); // displays text if above requirement is met
	}
	}
	
public void GradeCheck (int examScore) { // int examScore (what the user inputs) is the value that is used in this void
	if( examScore >= 90) { // compares user input to check if it is greater than or equal to 90
		Console.WriteLine("Great job! Your grade is: A"); // if it is greater than or equal to 90, displays text
	} else if (examScore >= 80) { // compares user input to check if it is greater than or equal to 80
		Console.WriteLine("Keep up the good work! Your grade is: B"); // if it is greater than or equal to 80, displays text
	} else if (examScore >= 70) { // compares user input to check if it is greater than or equal to 70
		Console.WriteLine("Do you have any late assignments? Your Grade is: C"); // if it is greater than or equal to 70, displays text
	} else if (examScore >= 60) { // compares user input to check if it is greater than or equal to 60
		Console.WriteLine("Are there any extra credit opportunities? Your Grade is: D"); // if it is greater than or equal to 60, displays text
	}	else if (examScore >= 50) { // compares user input to check if it is greater than or equal to 50
		Console.WriteLine("Please talk to your instructor. Your Grade is: F"); // if it is greater than or equal to 50, displays text
		} else { // compares user input to check if it is less than or equal to 50
		Console.WriteLine("Please talk to your instructor. Your Grade is: F"); // if it is less than or equal to 50, displays text
	}
	}
}
