using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uthyrning.Databas;
using UthyrningSystem.Entiteter;
using static System.Collections.Specialized.BitVector32;
namespace Uthyrning.Affärslager
{
    public class StationService
    {
        private readonly StationRepository _repository;

        public StationService()
        {
            _repository = Custom_RepostioryContainer.GetRepository<StationRepository>();
        }

        public List<Station> HämtaStationer()
        {
           return _repository.HämtaStationer();
        }

        public void LäggTillStation(Station station)
        {
            _repository.LäggTillStation(station);
        }
        public Station SkapaStation(string stationID, string stationNamn, string adress, string ort, int kapacitet) 
        {
            return new Station(stationID, stationNamn, adress, ort, kapacitet);

        }

    }
}
