namespace FactoryMethod.Vehicles
{
    internal class MotorCycle : IVehicles
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a entrega");
        }
    }
}
