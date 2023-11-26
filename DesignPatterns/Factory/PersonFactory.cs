
using Common;

namespace Factory
{
    public static class PersonFactory
    {
        private static IReadOnlyList<Person> randomPeople = new List<Person>()
        {
            new Person(1, "Emma Thompson", "Sparky@email.com",  "Radiant"),
            new Person(2, "Jackson Lee", "Turbo@email.com", "Quantum"),
            new Person(3, "Olivia Martinez", "Zephyr@email.com",  "Serendipity"),
            new Person(4, "Ethan Mitchell", "Blaze@email.com",  "Nimbus"),
            new Person(5, "Ava Robinson", "Luna@email.com",  "Velocity"),
            new Person(6, "Liam Taylor", "Thunder@email.com",  "Cascade"),
            new Person(7, "Sophia Davis", "Zenith@email.com",  "Celestial"),
            new Person(8, "Mason Harris", "Phoenix@email.com",  "Ephemeral"),
            new Person(9, "Isabella Turner", "Pegasus@email.com",  "Ethereal"),
            new Person(10, "Noah Baker", "Nebula@email.com",  "Luminescent"),
        };

        public static IPerson CreateJohnDoe()
        {
            return new Person(0, "John Doe", "john.doe@email.com", "password123");
        }

        public static IPerson CreateJaneDoe()
        {
            return new Person(0, "Jane Doe", "jane.doe@email.com", "5vfd47vfvd-89");
        }

        public static IPerson GetRandomPerson()
        {
            var random = new Random();
            int index = random.Next(0, randomPeople.Count);

            return randomPeople[index];
        }
    }
}
