using Common;

namespace Builder
{
    internal class PersonBuilder
    {
        private int id;
        private string name;
        private string email;
        private string password;

        public PersonBuilder Id(int id)
        {
            this.id = id;
            return this;
        }

        public PersonBuilder Name(string name)
        {
            this.name = name;
            return this;
        }

        public PersonBuilder Email(string email)
        {
            this.email = email;
            return this;
        }

        public PersonBuilder Password(string password)
        {
            this.password = password;
            return this;
        }

        public Person Build()
        {
            return new Person(id, name, email, password);
        }
    }
}
