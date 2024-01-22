using System;

namespace figuringStuffOut
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Hello World!");

Console.WriteLine("figuring it out"); //writelines are used to display text and variable values

/* these symbols are for comments on multiple lines*/

Console.WriteLine("I'm figuring out how to use Git");

string name = "Pepper"; //strings are for storing a sequence of characters
Console.WriteLine(name); // expected output is the name Pepper

Console.WriteLine("   ");

int myNumOne = 13;// int(egers) store whole numbers w/out decimals
myNumOne = 27; 
Console.WriteLine(myNumOne);// expected output is 27, because the value of myNumOne changed

Console.WriteLine(" ");
Console.WriteLine("howdy " + name + "!");

Console.WriteLine("   ");

string firstName = "John";
string lastName = " Doe";
string fullName = firstName + lastName;
Console.WriteLine(fullName); // expected output is John Doe

int x = 9; // int(egers) store whole numbers w/out decimals
int y = 4, z = -10; // this is assigning values to variables
Console.WriteLine(x+y+z); // expected output is the sum of x+y+z

Console.WriteLine("   ");

float myNumTwo = 5.75F; //floats are values with fractions/decimals
Console.WriteLine(myNumTwo); //expected output is 5.75 for the myNumTwo variable

double myNumThree = 19.99D;
Console.WriteLine(myNumThree); //expected output is 19.99

float f1 = 35e3f; 
double d1 = 12E4d; 
Console.WriteLine(f1);//expected output is 35e3f, or 35000
Console.WriteLine(d1);// expected output is 12e4d, or 120000

Console.WriteLine("   ");

bool isOrangeTheBestColor = true; //booleans are for storing values with 2 states, true or false
Console.WriteLine(isOrangeTheBestColor); //expected output is true

Console.WriteLine("   ");

int w = 100 + 50; // arithmetic operators are used for arithmetic
int i = 5;
Console.WriteLine(w); // expected output is 150
Console.WriteLine(w+i); // expected ouput is 155

int a = 10; 
Console.WriteLine(a);
a += 5; // assignment operators assign and transform values, will add variable a (10) to 5
Console.WriteLine(a); //expected output is 15 (10+5), not 10

Console.WriteLine("   ");

int b= 20, c= 44; 
Console.WriteLine(b==c); // comparison operators compare operands, expected output is false, because 20 is not equal to 44
Console.WriteLine(b != c);// expected output is true, b and c are not equal
Console.WriteLine(b> 10 && c< 30); // logical operators determines the logic between variables and values. this tests if b(20) is greater than 10 and if 44 is less than 30. the expeccted output is false.
int d=60,e=13;
Console.WriteLine(d&e); //bitwise operators perform operations on values. expected outcome is 12.
Console.WriteLine(b&c); // expected outcome is 4.

}
}
}
