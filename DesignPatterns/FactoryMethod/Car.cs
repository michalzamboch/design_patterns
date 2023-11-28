
namespace FactoryMethod
{
    internal class Car : IVehicle
    {
        public Car(string name) 
        {
            Name = name;
        }

        public string Name { get; set; } = string.Empty;

        public void Drive()
        {
            Console.WriteLine($"Driving a car: {Name}");
        }
    }
}
