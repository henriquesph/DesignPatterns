namespace FactoryMethod.Vehicles
{
    class Bike : IVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda de bike");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos o trajeto");
        }
    }
}
