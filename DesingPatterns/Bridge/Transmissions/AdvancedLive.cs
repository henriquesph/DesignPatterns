using Bridge.Platforms;

namespace Bridge.Transmissions
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform) 
        { 
        }

        public void Subtile()
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na live");
        }

        public void Record()
        {
            Console.WriteLine("Iniciando a gravação");
        }
    }
}
