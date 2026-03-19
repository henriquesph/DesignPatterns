using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAirCraft()
        {
            return new Drone();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
