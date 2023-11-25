using Prototype;

Console.Title = "Builder";


Car audi = new("Audi", "A6", 250, 500);
Car anotherAudi = audi.Clone();

Console.WriteLine(audi.ToString());
Console.WriteLine(anotherAudi.ToString());

if (audi.Equals(anotherAudi))
{
    Console.WriteLine("Equal cars.");
}
else
{
    Console.WriteLine("Not equal cars.");
}
