using System;
public class Program
{
	public void Main()
	{
		Console.WriteLine("What is the current temperature in celsius?"); // will display temperature question
		string userTemp = Console.ReadLine();  // will prompt user input, will save that input as userTemp
		int temperature = Int32.Parse(userTemp); // changes the string variable userTemp to int variable temperature
		CheckTemperature(temperature); // runs public void CheckTemperature with variable temperature
	
	Console.WriteLine(" ");  // this is to put a blank line in the output. There's a better way to do this, right?
		
		Console.WriteLine("What is your exam score as a percentage?"); // will display the exam score question
		string userScore = Console.ReadLine(); // will prompt user input, will save input as userScore
		int examScore = Int32.Parse(userScore); // changes the string variable userScore to int variable examScore
		GradeCheck(examScore); // runs public void examScore with the variable examScore
		
	Console.WriteLine(" ");
		
		Console.WriteLine("What is your favorite subject?"); // will display question
		string userSubject = Console.ReadLine(); // will prompt user input and save it as userSubject
		CheckSubject(userSubject); // will run public void checkSubject with the variable userSubject
		
	}
	public void CheckTemperature(int temperature) {  // the int temperature is the value that is used in this void
		if(temperature >= 30) { // compares the user's input (temperature) to check if it is greater than 30
			Console.WriteLine("Heat stroke is serious. Make sure to drink water and wear a hat.");// displays text, if above requirement is met
		} else if (temperature >= 20) { // if user's input does not meet the first if statement's requirement, checks if it meets this one
			Console.WriteLine("The weather must be nice! I advise wearing removable layers."); // displays text if above requirement is met
		} else if (temperature >= 10) { // if user's input does not meet the first 2 requirements, checks this one
			Console.WriteLine("Is there wind chill? If so, I suggest a thicker sweater.If not, I suggest a lighter sweater."); // displays text if above requirement is met
		} else { // if user's input does not meet first 3 requirements, checks this one
			Console.WriteLine("It's pretty cold! I advise a quality coat, and closed-toe shoes."); //displays text if above requirement is met
	}

	}
	
public void GradeCheck (int examScore) { // int examScore (what the user inputs) is the value that is used in this void
	if( examScore >= 90) { // compares user input to check if it is greater than or equal to 90
		Console.WriteLine("Great job! Your grade is: A"); // if it is greater than or equal to 90, displays text
	} else if (examScore >= 80) { // compares user input to check if it is greater than or equal to 80
		Console.WriteLine("Keep up the good work! Your grade is: B"); // if it is greater than or equal to 80, displays text
	} else if (examScore >= 70) { // compares user input to check if it is greater than or equal to 70
		Console.WriteLine("Do you have any late assignments? Your Grade is: C"); // if it is greater than or equal to 70, displays text
	} else if (examScore >= 60) {  // compares user input to check if it is greater than or equal to 60
		Console.WriteLine("Are there any extra credit opportunities? Your Grade is: D"); // if it is greater than or equal to 60, displays text
	}	else if (examScore >= 50) { // compares user input to check if it is greater than or equal to 50
		Console.WriteLine("Please talk to your instructor. Your Grade is: F"); // if it is greater than or equal to 50, displays text
		} else {  // compares user input to check if it is less than or equal to 50
		Console.WriteLine("Please talk to your instructor. Your Grade is: F"); // if it is less than or equal to 50, displays text
	}
}
public void CheckSubject (string subject) { // subject is the expression that is being evaluated
	switch (subject.ToLower()) { // creates switch block, .ToLower makes user inputs case-insensitive
		case "math": // checks if keyword "math" was inputed
		Console.WriteLine("What a useful subject! Please continue to practice mathematical concepts!"); // if keyword was inputed, displays text
		break; // stops the execution of the switch block
		case "art": // checks if keyword "art" was inputed
		Console.WriteLine("Art is fun to create and look at! Please continue to develop your personal style!");  // if keyword was inputed, displays text
		break; // stops the execution of the switch block
		case "english": // checks if keyword "english" was inputed
		Console.WriteLine("Reading and writing are important skills! Please continue to practice your argumentative essays!"); // if keyword was inputed, displays text
		break; // stops the execution of the switch block
		case "history": // checks if keyword "history" was inputed
		Console.WriteLine("There are so many facets to history! Please continue to learn from the past!");  // if keyword was inputed, displays text
		break; // stops the execution of the switch block
		case "science": // checks if keyword "science" was inputed
		Console.WriteLine("What a broad subject! Please continue to learn about natural sciences!");  // if keyword was inputed, displays text
		break; // stops the execution of the switch block
		case "p.e.": // checks if keyword "p.e." was inputed
		Console.WriteLine("Physical activity is important! Please continue to participate safely!");  // if keyword was inputed, displays text
		break; // stops the execution of the switch block
	}
	}
}
