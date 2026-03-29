using ChainOfResponsability.Middlewares;

namespace ChainOfResponsability.Servers
{
    class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();
        private Middleware midleaware;

        public void SetMiddleware(Middleware midleaware)
        {
            this.midleaware = midleaware;
        }

        public Boolean LogIn(string email, string password)
        {
            if(midleaware.Check(email, password))
            {
                Console.WriteLine("Usuario autorizado com sucesso");
                Console.WriteLine("Seja bem-vindo");
                return true;
            }
            return false;
        }

        public void RegisterUser(string email, string password) 
        {
            users[email] = password;
        }

        public Boolean HasEmail(string email)
        {
            return users.ContainsKey(email);
        }
        public Boolean IsValidPassword(string email, string password) {
            string value = "";
            users.TryGetValue(email, out value);
            return password == value;
        }

        public Boolean IsPasswordWeak(string password)
        {
            if(password == "123456")
            {
                return true;
            }
            return false;
        }
    }
}
