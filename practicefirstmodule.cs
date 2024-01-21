using System;

namespace figuringStuffOut
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("Hello World!"); // I am commenting

Console.WriteLine("figuring it out"); 

/* i am learning. commenting commenting to get to two lines. typing typing typing typing finally ok */

Console.WriteLine("i'm still not too sure how to use git");

string name = "pepper";
Console.WriteLine(name);

Console.WriteLine("   ");

int myNumOne = 13;
myNumOne = 27;
Console.WriteLine(myNumOne);

Console.WriteLine(" ");
Console.WriteLine("howdy " + name + "!");

Console.WriteLine("   ");

string firstName = "john";
string lastName = " doe";
string fullName = firstName +lastName;
Console.WriteLine(fullName);

int x = 9;
int y = 4, z = -10;
Console.WriteLine(x+y+z);

Console.WriteLine("   ");

float myNumTwo = 5.75F;
Console.WriteLine(myNumTwo);

double myNumThree = 19.99D;
Console.WriteLine(myNumThree);

float f1 = 35e3f;
double d1 = 12E4d;
Console.WriteLine(f1);
Console.WriteLine(d1);

bool isOrangeTheBestColor = true;
Console.WriteLine(isOrangeTheBestColor);

int w = 100 + 50;
Console.WriteLine(w);
int a = 10;
a += 5;
Console.WriteLine(a);
}
}
}
