
namespace Prototype
{
    internal class Car : IPrototype<Car>
    {
        private readonly string brand;
        private readonly string name;
        private readonly int topSpeed;
        private readonly int horsePower;

        public Car(string brand, string name, int topSpeed, int horsePower)
        {
            this.brand = brand;
            this.name = name;
            this.topSpeed = topSpeed;
            this.horsePower = horsePower;
        }

        public Car DeepClone()
        {
            return new Car(brand, name, topSpeed, horsePower);
        }

        public Car ShallowClone()
        {
            object clone = MemberwiseClone();
            return (Car)clone;
        }

        public override string ToString()
        {
            return $"{brand} {name} top speed: {topSpeed} hp: {horsePower}";
        }
    }
}
