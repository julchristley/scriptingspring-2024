using System;
public class Program
{
public void Main ()
{
Console.WriteLine("Is the current temperature over 30 degrees celsius? Yes or No?");
string temperature =  Console.ReadLine( );
	CheckTemperature(temperature);
	
	}
public void CheckTemperature (string temperature) {
	if(temperature == "yes") {
		Console.WriteLine("Heat stroke is serious. Make sure to drink water and stay inside.");
	} else {
		Console.WriteLine("The weather must be nice! You must be enjoying it!");
	}
}
}

/* another option?????? i don't know what's going on
using System;
public class Program
{
public void Main ()
{
Console.WriteLine("Is the current temperature over 30 degrees celsius?");
string temperature;
	temperature = Console.ReadLine( );
	switch (temperature)
	{
		case yes:
		Console.WriteLine("Heat stroke is serious. Make sure to drink water and stay inside.");
		break;
		case no:
		Console.WriteLine("The weather must be nice! You must be enjoying it!");
		break;
}
}
}
*/
