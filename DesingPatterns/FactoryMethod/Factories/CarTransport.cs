using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class CarTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new Car();
        }
    }
}