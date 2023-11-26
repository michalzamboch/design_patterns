using Prototype;

Console.Title = "Prototype";

Car audi = new("Audi", "A6", 250, 500);
Car anotherAudi = audi.DeepClone();

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
