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

       
        public List<Användare> HämtaAnvändare()
        {
            return databas.HämtaAnvändare();
        }
    }
}
