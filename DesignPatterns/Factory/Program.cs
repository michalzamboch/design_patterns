using Common;
using Factory;

Console.Title = "Factory";

IPerson johnDoe = PersonFactory.CreateJohnDoe();
Console.WriteLine(johnDoe);

IPerson randomperson = PersonFactory.GetRandomPerson();
Console.WriteLine(randomperson);
