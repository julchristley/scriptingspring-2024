using System; // this is from the tutorial

public class Program
{
	public void Main()
	{
	Console.WriteLine("yo");
	doMath(10, 4); // calling doMath void function
	doMath(20, 7);
	doMath(30, 15);
	Compare(4,3);
	Compare(3,4); // this will not return anything if only running if(value>value2), because it is false
	CheckPassword("demondays");
	CheckPassword("plasticbeach");
	}
	
	public void doMath (int value, int value2) { // describing (declaring?) void function
		var number = value + value2;
		Console.WriteLine(number);
	}
	public void Compare (int value, int value2)	{
		if(value > value2) 	{
			Console.WriteLine("True, the first is greater");
		}  else	{
		     Console.WriteLine("False, the second is greater");
		}
	}
public void CheckPassword (string password){
	if(password == "plasticbeach") {
		Console.WriteLine("Correct Password");
	} else { 
		Console.WriteLine("Incorrect Password");
	}
}
}
