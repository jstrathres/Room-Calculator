Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
Console.WriteLine();

//prompt
Console.Write("Enter length: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Enter width: ");
double width = double.Parse(Console.ReadLine());

Console.Write("Enter a height: ");
double height = double.Parse(Console.ReadLine());

//variables
double area = (length * width);
double perimeter = 2 * (length + width);
double volume = (length * width * height);
double surfaceArea = ((length * width) + (height * width) + (length * height)) * 2;

//display back
Console.WriteLine();
Console.WriteLine("the area: " + area);
Console.WriteLine("the perimeter: " + perimeter);
Console.WriteLine();
Console.WriteLine("the volume: " + volume);
Console.WriteLine("the suface area: " + surfaceArea);
Console.WriteLine();

//extra challenge
if (surfaceArea <= 250)
{
    Console.WriteLine("the room is small");
}
else if (surfaceArea > 250 && surfaceArea < 650)
{
    Console.WriteLine("the room is medium");
}
else if (surfaceArea > 650)
{ 
    Console.WriteLine("the room is large");
}
Console.WriteLine("Thank you for using the Room Detail Generator!");  