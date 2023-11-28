
using FactoryMethod;

Console.Title = "Factory method";

IFactoryVehicle factory = new VehicleFactory();

IVehicle audi = factory.ProduceVehicle("car", "Audi");
IVehicle peterbilt = factory.ProduceVehicle("truck", "Peterbilt");

audi.Drive();
peterbilt.Drive();
