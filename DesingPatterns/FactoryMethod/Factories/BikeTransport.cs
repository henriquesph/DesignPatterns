using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class BikeTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new Bike();
        }
    }
}