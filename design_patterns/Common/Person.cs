namespace Common
{
    public class Person : IPerson
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public Person(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return $"{Id}. \"{Name}\" {Email} {Password}";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
