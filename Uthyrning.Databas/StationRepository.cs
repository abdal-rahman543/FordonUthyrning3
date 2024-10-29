using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UthyrningSystem.Entiteter;
namespace Uthyrning.Databas
{
    public class StationRepository
    {
        private InMemoryDatabase databas;
        public StationRepository()
        {
            databas = InMemoryDatabase.Instans;
        }

        public List<Station> HämtaStationer()
        {
            return databas.HämtaStationer();
        }

        public void LäggTillStation(Station nyStation)
        {
            databas.LäggTillStation(nyStation);
        }
    }
}
