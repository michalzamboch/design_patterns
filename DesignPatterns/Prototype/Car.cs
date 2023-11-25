using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Car : IPrototype
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

        public Car Clone()
        {
            return new Car(brand, name, topSpeed, horsePower);
        }

        public override string ToString()
        {
            return $"{brand} {name} top speed: {topSpeed} hp: {horsePower}";
        }
    }
}
