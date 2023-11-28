
namespace FactoryMethod
{
    internal class Truck : IVehicle
    {
        public Truck(string name) 
        {
            Name = name;
        }

        public string Name { get; set; } = string.Empty;

        public void Drive()
        {
            Console.WriteLine($"Driving a truck: {Name}");
        }
    }
}
