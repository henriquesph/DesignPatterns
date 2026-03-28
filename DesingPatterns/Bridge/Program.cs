using Bridge.Platforms;
using Bridge.Transmissions;

namespace Bridge
{
    class Program
    {
        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtile();
            live.Comments();
            live.Record();
            live.Result();
        }

        static void Main(string[] args)
        {
            StartLiveAdvanced(new Youtube());
            StartLive(new Facebook());
            StartLive(new TwitchTV());
            StartLive(new DLive());
            Console.ReadLine();
        }
    }
}