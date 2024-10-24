
using Uthyrning.Databas;
using UthyrningSystem.Entiteter;

namespace Uthyrning.Affärslager
{
    public class LoginService
    {
        readonly LoginRepository  repository;

        public LoginService() 
        {
            repository = new LoginRepository();
        }

        public Användare Login(string username, string password)
        {
            if (username != null && password != null)
            {
               return repository.Login(username, password);
            }
            else
            {
                return null;
            }
        }


    }
}
