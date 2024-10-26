
using Uthyrning.Databas;
using UthyrningSystem.Entiteter;

namespace Uthyrning.Affärslager
{
    public class LoginService
    {
        readonly LoginRepository  _repository;

        public LoginService() 
        {
            _repository = new LoginRepository();
        }

        public Användare Login(string userID, string password)
        {
            List<Användare> AnvändareLista = _repository.HämtaAnvändare();
            if (userID != null && password != null)
            {
                userID = userID.Trim();
                password = password.Trim();


                foreach (Användare user in AnvändareLista)
                {
                    if (user.ID.Equals(userID) && user.Lösenord.Equals(password))
                    {
                        return user;
                    }

                }
              
            }
            
           return null;
            
        }


    }
}
