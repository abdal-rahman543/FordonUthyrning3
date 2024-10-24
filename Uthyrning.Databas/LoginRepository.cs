using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UthyrningSystem.Entiteter;

namespace Uthyrning.Databas
{
    public class LoginRepository
    {
        private InMemoryDatabase databas;
        public LoginRepository()
        {
            databas = InMemoryDatabase.Instans;
        }

        public Användare Login(string username, string password)
        {
            foreach(Användare user in InMemoryDatabase.AllaAnvändare)
            {
                if(user.FörNamn.Equals(username) && user.Lösenord.Equals(password))
                {
                    return user;
                }
              
            }
            return null;
           
        }

    }
}
