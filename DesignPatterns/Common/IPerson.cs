namespace Common
{
    public interface IPerson
    {
        int Id { get; }
        string Name { get; }
        string Email { get; }
        string Password { get; }

        string ToString();
        void Print();
    }
}
