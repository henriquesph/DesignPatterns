using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class MotorcycleTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new MotorCycle();
        }
    }
}