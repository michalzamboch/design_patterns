using Builder;
using Common;

Console.Title = "Builder";

IPerson JohnDoe = new PersonBuilder()
    .Id(1)
    .Name("John Doe")
    .Email("johndoe@email.com")
    .Password("password")
    .Build();

Console.WriteLine(JohnDoe.ToString());
