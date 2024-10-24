using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UthyrningSystem.Entiteter;
using static UthyrningSystem.Entiteter.Enums;

namespace Uthyrning.Databas
{
    public class RegistreraRepository
    {
        private InMemoryDatabase databas;
        public RegistreraRepository()
        {
            databas = InMemoryDatabase.Instans;
        }

        public bool Registrera(string förnamn, string efternamn,string epost, string lösenord, BehörighetsNivå status)
        {
            return databas.Registrera(förnamn,efternamn,epost,lösenord,status);
        }

    }
}
