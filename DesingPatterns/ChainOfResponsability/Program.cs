using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server server;
        static void Init()
        {
            server = new Server();
            server.RegisterUser("master@master.com.br", "32243233213");
            server.RegisterUser("user@user.com.br", "123456");


            Middleware middleware = new CheckUserMiddleware(server);
            
            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckWeakPassword());
            server.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            Boolean done = false;
            do
            {
                Console.WriteLine("Digite o seu e-mail");
                string email = Console.ReadLine();

                Console.WriteLine("Digite sua senha");
                string password = Console.ReadLine();

                done = server.LogIn(email, password);
            } while (!done);

            Console.ReadLine();
        }
    }
}