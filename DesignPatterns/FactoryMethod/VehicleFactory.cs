
namespace FactoryMethod
{
    internal class VehicleFactory : IFactoryVehicle
    {
        public IVehicle ProduceVehicle(string vehicleType, string vehicleName)
        {
            if (string.IsNullOrEmpty(vehicleType))
            {
                throw new ArgumentNullException("Unknown vehicle type");
            }

            if (vehicleType == "car")
            {
                return new Car(vehicleName ?? string.Empty);
            }
            else if (vehicleType == "truck")
            {
                return new Truck(vehicleName);
            }
            else
            {
                throw new ArgumentNullException("Unknown vehicle type");
            }
        }
    }
}
