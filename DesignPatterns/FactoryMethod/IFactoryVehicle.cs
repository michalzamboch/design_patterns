namespace FactoryMethod
{
    public interface IFactoryVehicle
    {
        IVehicle ProduceVehicle(string vehicleType, string vehicleName);
    }
}
