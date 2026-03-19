namespace AbstractFactory.Landvehicles
{
    class Scooter : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Encomenda na mochila");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega na scooter");
        }
    }
}
