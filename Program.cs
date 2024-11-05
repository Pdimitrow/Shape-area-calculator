using System.ComponentModel.Design;
using System.Diagnostics;

string answer;
float result;
Console.WriteLine("What shape would you like to find the area of ? Please enter 'm' for rectangle, or any other key for circle.");

answer = Console.ReadLine();

if (answer == "m")
{
    Console.WriteLine("Please enter the height of the rectangle.");
    float height = float.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the width of the rectangle.");
    float width = float.Parse(Console.ReadLine());

    result = height * width;
}
else
{
    Console.WriteLine("Please enter the radius of the circle.");
    float radius = float.Parse(Console.ReadLine());

    result = (float)Math.PI * (radius * radius);
}
Console.WriteLine("The result is " + result);
Console.ReadKey();


    
